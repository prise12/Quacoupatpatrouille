using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using System.Collections.Generic;
using Pinpon;

namespace sae24_gestion_des_pompiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");


            //remplissage des casernes (séléction et rattachement dans modification)
            string requete = "select nom from Caserne";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                string caserne =drd["nom"].ToString();
                cbo_selection_caserne.Items.Add(caserne) ;
                cbo_caserne_rattachement.Items.Add(caserne) ;
            }
            drd.Close();
            //remplissage de la combo box contenant les grades dans ajouter pompier
            string requete_grade = "select code from grade";
            SQLiteCommand cmod_grade = new SQLiteCommand(requete_grade, Connexion.Connec);
            SQLiteDataReader drd_grade = cmod_grade.ExecuteReader();
            while (drd_grade.Read())
            {
                string grade = drd_grade["code"].ToString();
                cbo_ajouter_grade.Items.Add(grade);
                cbo_grade_pompier.Items.Add(grade);
            }
            drd_grade.Close();

            cbo_selection_pompier.Visible = false;
            grp_carriere_pompier.Visible = false;
            grp_nouveau_pompier.Visible = false;
            grp_infos_pompier.Visible = false;
            chk_plusdinfos.Visible = false;
        }

        private void cbo_selection_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_selection_pompier.Items.Clear();

            int idcaserne = cbo_selection_caserne.SelectedIndex + 1;
            string requete = "SELECT p.nom FROM pompier p JOIN Affectation a ON p.matricule = a.matriculePompier WHERE a.dateFin IS NULL and idCaserne = " + idcaserne;
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            //remplissage des pompiers
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string destination = dr["nom"].ToString();
                cbo_selection_pompier.Items.Add(destination);
            }

            dr.Close();
            cbo_selection_pompier.Visible = true;
        }

        private void cbo_selection_pompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on vide les textbox, listbox et compagnie qui auraient pu etre remplies auparavant
            cbo_caserne_rattachement.SelectedIndex = -1;
            txt_matricule.Text = txt_matricule.Text.Substring(0, 9);
            foreach (Control c in grp_infos_pompier.Controls)
            {
                if (c is TextBox t)
                {
                    t.Clear();
                }
            }
            foreach (Control c in grp_carrière.Controls)
            {
                if (c is TextBox t)
                {
                    t.Clear();
                }
            }
            foreach (Control c in grp_carriere_pompier.Controls)
            {
                if (c is ListBox l)
                {
                    l.Items.Clear();
                }
            }

            //on crée une variable pour stocker le matricule du pompier pour plus tard
            int matricule_pompier = 0;
            //on remplit la cbo caserne à partir de l'autre cbo
            cbo_caserne_rattachement.SelectedIndex = cbo_selection_caserne.SelectedIndex;
            //mise en place du dr
            string nom = cbo_selection_pompier.Text;
            string requete = "select * from pompier where nom = '" + nom + "'";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader data = cmd.ExecuteReader();
            //partie picture box
            string chemin = "ImagesGrades/";
            string extension = ".png";
            string grade = "";
            while (data.Read())
            {
                txt_matricule.Text += " " + data.GetInt16(0).ToString();
                matricule_pompier = data.GetInt16(0);
                txt_nom_pompier.Text += " " + data.GetString(1);
                txt_prenom_pompier.Text += " " + data.GetString(2);
                if (data.GetString(3) == "m") { rdb_sexe_pompier.Checked = true; rdb_sexe_feminin.Checked = false; }
                else { rdb_sexe_feminin.Checked = true; rdb_sexe_pompier.Checked = false; }
                if (data.GetString(5) == "p") { rdb_professionel.Checked = true; rdb_volontaire.Checked = false; }
                else { rdb_volontaire.Checked = true; rdb_professionel.Checked = false; }
                txt_telephone_pompier.Text += " " + data.GetString(6);
                txt_bip_pompier.Text += " " + data.GetInt16(7).ToString();
                grade = data.GetString(10);
                cbo_grade_pompier.SelectedItem = grade;
                txt_date_embauche_pompier.Text += data.GetString(11);
            }
            data.Close();
            pictureBoxPompier.Image = Image.FromFile(chemin + grade + extension);

            //remplissage habilitations
            string requete2 = @"select h.libelle from Habilitation h 
                                join Passer p on h.id = p.idHabilitation join Pompier pom on p.matriculePompier = pom.matricule 
                                WHERE pom.matricule = p.matriculePompier and pom.matricule = " + matricule_pompier;
            SQLiteCommand cmd2 = new SQLiteCommand(requete2, Connexion.Connec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd2);

            SQLiteDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                string habilitations = dr["libelle"].ToString();
                lst_habilitations.Items.Add(habilitations);
            }

            dr.Close();
            //remplissage affectations
            string requete_affectations = @"select a.dateA, c.nom from Affectation a join Caserne c on a.idCaserne = c.id 
                                            where a.matriculePompier = " + matricule_pompier;
            SQLiteCommand cmd_affectation = new SQLiteCommand(requete_affectations, Connexion.Connec);
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd2);

            SQLiteDataReader dr2 = cmd_affectation.ExecuteReader();
            while (dr2.Read())
            {
                string affectation = dr2["dateA"].ToString() + " " + dr2["nom"].ToString();
                lst_affectations.Items.Add(affectation);
            }

            dr2.Close();
            grp_infos_pompier.Visible = true;
            chk_plusdinfos.Visible = true;
        }

        private void chk_plusdinfos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_plusdinfos.Checked)
            {
                grp_carriere_pompier.Visible = true;
                chk_plusdinfos.Text = "Moins d'informations";
            }
            else
            {
                grp_carriere_pompier.Visible = false;
                chk_plusdinfos.Text = "Plus d'infos";
            }
        }

        private void btn_ajouter_pompier_Click(object sender, EventArgs e)
        {
            login frm = new login();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //on crée des variables qu'on utilisera dans la requête d'ajout
                string date_embauche = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date_naissance = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string sexe = "";
                string statut = "";
                //sexe
                if (rdb_ajouter_sexe_feminin.Checked)
                {
                    sexe += "f";
                }
                if (rdb_ajouter_sexe_masculin.Checked)
                {
                    sexe += "m";
                }
                //statut
                if (rdb_ajout_professionnel.Checked)
                {
                    statut += "p";
                }
                if (rdb_ajout_volontaire.Checked)
                {
                    statut += "v";
                }
                //on récupère le matricule en fonction de la caserne choisie
                int selected_index_caserne = cbo_selection_caserne.SelectedIndex + 1;
                string requete_matricule_pompier = "select max(matriculePompier) from Affectation";
                SQLiteCommand cmd = new SQLiteCommand(requete_matricule_pompier, Connexion.Connec);
                object resultat = cmd.ExecuteScalar();
                int matricule = (resultat != DBNull.Value ? Convert.ToInt32(resultat) : 0) + 1;
                MessageBox.Show(matricule.ToString());
                //REQUETE POUR AJOUTER LE POMPIER
                string requete_ajout_pompier = @"INSERT INTO Pompier 
                                                (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) 
                                            VALUES (" + matricule + ", " + "'" + txt_ajout_nom.Text + "', " + "'" + txt_ajout_prenom.Text + "'," + "'" + sexe 
                                            + "', '" + date_naissance + "', '" + statut + "', " + txt_ajouter_telephone.Text + ", " + txt_ajouter_bip.Text 
                                            + ", " + 0 + ", " + 0 + ", '" + cbo_ajouter_grade.SelectedItem.ToString() + "', '" + date_embauche + "');";
                SQLiteCommand cmd_ajout_pompier = new SQLiteCommand(requete_ajout_pompier, Connexion.Connec);
                cmd_ajout_pompier.ExecuteNonQuery();

                string requete_ajout_pompier2 = @"INSERT into Affectation(matriculePompier, dateA, dateFin, idCaserne) 
                                            VALUES(" + matricule + ", '" + date_embauche + "', null, " + (cbo_selection_caserne.SelectedIndex + 1) + ")";
                SQLiteCommand cmd_ajout_pompier2 = new SQLiteCommand(requete_ajout_pompier2, Connexion.Connec);
                MessageBox.Show(requete_ajout_pompier2);
                cmd_ajout_pompier2.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Ajout annulé");
            }
        }

        private void btn_nouveau_pompier_Click(object sender, EventArgs e)
        {
            grp_nouveau_pompier.Visible = true;
        }

        private void btn_annuler_ajout_pompier_Click(object sender, EventArgs e)
        {
            grp_nouveau_pompier.Visible = false;
            cbo_ajouter_grade.SelectedIndex = -1;
            foreach (Control c in grp_nouveau_pompier.Controls)
            {
                if (c is TextBox b)
                {
                    b.Clear();
                }
            }
            foreach (Control c in grp_nouveau_pompier.Controls)
            {
                if (c is RadioButton r)
                {
                    r.Checked = false;
                }
            }

            foreach (Control c in grp_ajout_sexe.Controls)
            {
                if (c is RadioButton r)
                {
                    r.Checked = false;
                }
            }

            foreach (Control c in grp_nouveau_pompier.Controls)
            {
                if (c is DateTimePicker d)
                {
                    d.Value = DateTime.Now;
                }
            }
        }


        //Gestion des caractères autorisés dans les texbox

        private void txt_ajout_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_ajout_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_ajouter_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_ajouter_bip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txt_telephone_pompier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void btn_actualiser_Click_1(object sender, EventArgs e)
        {
            login frm = new login();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string type = "";
                if (rdb_professionel.Checked)
                {
                    type = "p";
                }
                else
                {
                    type = "v";
                }
                string requete_update_pompier = @"UPDATE Pompier SET type = '" + type + "', portable = " 
                                                + txt_telephone_pompier.Text + ", codeGrade ='" + cbo_grade_pompier.SelectedItem 
                                                + "' WHERE matricule =" + txt_matricule.Text.Substring(10, 4);
                SQLiteCommand cmd_update_pompier = new SQLiteCommand(requete_update_pompier, Connexion.Connec);
                MessageBox.Show(requete_update_pompier);
                cmd_update_pompier.ExecuteNonQuery();
                if (cbo_caserne_rattachement.SelectedIndex != cbo_selection_caserne.SelectedIndex)
                {
                    //ON TERMINE LAFFECTATION PRECEDENTE
                    string requete_update_caserne_pompier = @"update affectation set dateFin = date('now') 
                                                              where matriculePompier = " + txt_matricule.Text.Substring(10, 4);
                    SQLiteCommand cmd_update_caserne_pompier = new SQLiteCommand(requete_update_caserne_pompier, Connexion.Connec);
                    MessageBox.Show(requete_update_caserne_pompier);
                    cmd_update_caserne_pompier.ExecuteNonQuery();
                    //ON EN CREE UNE NOUVELLE
                    string requete_nvl_affectation = @"insert into Affectation (matriculePompier,dateA,dateFin,idCaserne) 
                                                     values (" + txt_matricule.Text.Substring(10, 4) + ",date('now'),null," 
                                                     + (cbo_caserne_rattachement.SelectedIndex + 1) + ")";
                    SQLiteCommand cmd_nvl_affectation = new SQLiteCommand(requete_nvl_affectation, Connexion.Connec);
                    MessageBox.Show(requete_nvl_affectation);
                    cmd_nvl_affectation.ExecuteNonQuery();
                }
            }
            else 
            {
                MessageBox.Show("mise à jour annulée");
            }
        }

        private void lbl_selection_pompier_Click(object sender, EventArgs e)
        {

        }

        private void ucNav1_Load(object sender, EventArgs e)
        {

        }
    }
}
