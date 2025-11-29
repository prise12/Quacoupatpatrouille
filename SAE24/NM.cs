using Pinpon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ucNouvelleMissionEnginsSae24;
using ucNouvelleMissionPompierSae24;



namespace frmSinistreSAE24
{
    public partial class frmSinistreSAE24 : Form
    {

        private DataTable dtPompier = new DataTable();
        private DataTable dtEngin = new DataTable();


        //pour la mise a jour de la base 
        int nMission;
        DateTime dateDeclenchment;

        public frmSinistreSAE24()
        {
            nMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1;
            InitializeComponent();
            lblNumeroMission.Text += nMission;
            lblDeclencheLe.Text += System.DateTime.Now.ToString();
            
            dtEngin.Columns.Add("codeTypeEngin");
            dtEngin.Columns.Add("numero");
            dtPompier.Columns.Add("matricule");
            dtPompier.Columns.Add("habilitation");
            dtPompier.Columns.Add("nom");
            dtPompier.Columns.Add("prenom");
            dtPompier.Columns.Add("codeGrade");

           
            dateDeclenchment = DateTime.Now;

            foreach (Control c in this.Controls)
            {
                c.MinimumSize = c.Size;
            }
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDeclencheLe_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnConstituerEquipe_Click(object sender, EventArgs e)
        {

            clearPnl();

            btnConfirmer.Visible = true;

            lblEnMob.Visible = true;    
            lblPomMob.Visible = true;   


            plnAffectation.Visible = true;

            dtEngin.Clear();
            dtPompier.Clear();

            //liste des engins mobilisés
            List<string> lstEngins = new List<string>();

            int indexSinistre = cmbNatureSinistre.SelectedIndex + 1;
            int indexCaserne = cmbCaserneAMobiliser.SelectedIndex + 1;



            if (indexSinistre != 0 && indexCaserne != 0)
            {
                foreach (DataRow row in MesDatas.DsGlobal.Tables["Necessiter"].Rows)
                {
                    if (Convert.ToInt16(row["idNatureSinistre"]) == indexSinistre)
                    {
                        int nbEngins = Convert.ToInt16(row["nombre"]);

                        //On verfie si les engins sont disponible pour la caserne selectionner dans le cmb box


                        if (affecterDispoEngins(Convert.ToString(row["codeTypeEngin"]), indexCaserne, nbEngins, lstEngins, dtEngin)) { }

                        else
                        {
                            //CHque caserne est analyser
                            for (int i = 0; i < MesDatas.DsGlobal.Tables["Caserne"].Rows.Count; i++)
                            {

                                if (affecterDispoEngins(Convert.ToString(row["codeTypeEngin"]), i + 1, nbEngins, lstEngins, dtEngin))
                                {
                                    MessageBox.Show("Pas assez d'engin dans la caserne" + indexCaserne + ", mission affecter à la caserne" + i + 1);
                                    //la nouvelle caserne affecter à la mission et inscrite dans le cmb
                                    cmbCaserneAMobiliser.SelectedIndex = i + 1;
                                    indexCaserne = i + 1;
                                }
                            }
                        }
                    }
                }


                //L'affectation s'est bien effectué et les dgv sont remplies

                if (affecterPompier(indexCaserne, lstEngins, dtPompier))
                {


                    //On modifie les booléen des tables pompier et engin pour signaler qu'il sont en mission et on place les user control

                    int i = 0;
                    foreach (DataRow row in dtEngin.Rows)
                    {
                        //on place lesz uc engin
                        ucEngindNM ucEngin = new ucEngindNM(row);
                        plnAffectation.Controls.Add(ucEngin);
                        ucEngin.Location = new System.Drawing.Point(24, 49 + i * 100);
                        i++;

                        
                    }

                    i = 0;
                    foreach (DataRow row in dtPompier.Rows)
                    {
                        //on place lesz uc pompier
                        UserControl1 ucPompier = new UserControl1(row);
                        plnAffectation.Controls.Add(ucPompier);
                        ucPompier.Location = new System.Drawing.Point(624, 49 + i * 100);
                        i++;

                        
                    }
                }

                //ou pas
                else
                {
                    MessageBox.Show("Mission annulé, la caserne " + indexCaserne + " n'as pas assez d'effectif !");

                    clearPnl();
                }

            }
            else
            {
                MessageBox.Show("Selectioner une caserne et une nature de sinistre");
            }

        }

        private bool affecterPompier(int idCaserne, List<string> lstEngins, DataTable dtPompier)
        {
            dtPompier.Rows.Clear();


            //List qui  vas contenir tous les pompier deja habilité a la mission pour eviter les doublon
            var lstPompier = new HashSet<int>();

            foreach (String codeEngin in lstEngins)
            {
                // liste qui vas stocker les habilitations requise pour un engin
                List<int> lstHabilitation = new List<int>();

                foreach (DataRow row in MesDatas.DsGlobal.Tables["Embarquer"].Rows)
                {
                    if (codeEngin == row["codeTypeEngin"].ToString())
                    {

                        for (int i = 0; i < Convert.ToInt16(row["nombre"]); i++)
                        {
                            lstHabilitation.Add(Convert.ToInt16(row["idHabilitation"]));
                        }
                    }
                }

                // On tente d'affecter un pompier pour chaque habilitation
                foreach (int idHabilitation in lstHabilitation.ToList()) // .ToList() pour éviter les erreurs pendant la suppression
                {
                    bool trouvé = false;

                    foreach (DataRow rowPasser in MesDatas.DsGlobal.Tables["Passer"].Rows)
                    {
                        int matricule = Convert.ToInt32(rowPasser["matriculePompier"]);
                        int hab = Convert.ToInt32(rowPasser["idHabilitation"]);

                        if (hab == idHabilitation && !lstPompier.Contains(matricule))
                        {
                            DataRow[] childRows = rowPasser.GetChildRows("relationPompier");
                            DataRow[] childRows2 = rowPasser.GetChildRows("relationPompier2");

                            if (childRows.Length == 0) continue;
                            if (childRows2.Length == 0) continue;

                            DataRow childRow = childRows[0];
                            DataRow childRow2 = childRows2[0];

                            string nom = childRow2["nom"].ToString();
                            string prenom = childRow2["prenom"].ToString();
                            string grade = childRow2["codeGrade"].ToString();

                            if (Convert.ToInt32(childRow["idCaserne"]) == idCaserne && Convert.ToInt32(childRow2["enMission"]) == 0 && Convert.ToInt16(childRow2["enConge"]) == 0)
                            {
                                // On l'affecte
                                dtPompier.Rows.Add(matricule, hab, nom, prenom,grade );
                                lstPompier.Add(matricule);
                                lstHabilitation.Remove(idHabilitation);
                                trouvé = true;
                                break;
                            }
                        }
                    }

                    if (!trouvé)
                    {
                        // Pas de pompier trouvé pour cette habilitation
                        return false;
                    }
                }
            }

            return true;
        }



        private bool affecterDispoEngins(string code, int idCaserne, int nbEngins, List<string> lstEngins, DataTable dtEngin)
        {


            //on parcour les lignes de la table Engin pour une caserne et on compte le nombre d'engin disponibles
            int compter = 0;

            var enginsDispo = new List<DataRow>();

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Engin"].Rows)
            {
                if (Convert.ToInt16(row["idCaserne"]) == idCaserne && row["codeTypeEngin"].ToString() == code && Convert.ToInt16(row["enMission"]) == 0 && Convert.ToInt16(row["enPanne"]) == 0)
                {
                    compter++;
                }
                enginsDispo.Add(row);
            }


            if (enginsDispo.Count >= nbEngins)
            {
                for (int i = 0; i < nbEngins; i++)
                {
                    var row = enginsDispo[i];
                    dtEngin.Rows.Add(code, i + 1);
                    lstEngins.Add(code);
                }
                return true;
            }
            return false;

        }


        private void grpInfoUsager_Enter(object sender, EventArgs e)
        {

        }

        private void frmSinistreSAE24_Load(object sender, EventArgs e)
        {

            foreach (DataRow row in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
            {
                cmbNatureSinistre.Items.Add(row["libelle"].ToString());
            }

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Caserne"].Rows)
            {
                string nomCaserne = row["nom"].ToString();
                cmbCaserneAMobiliser.Items.Add(nomCaserne.Substring(8, nomCaserne.Length - 8));

            }

            MesDatas.DsGlobal.EnforceConstraints = false;
            if(MesDatas.DsGlobal.Relations.Count == 0)
            {
                MesDatas.DsGlobal.Relations.Add("relationPompier", MesDatas.DsGlobal.Tables["Passer"].Columns["matriculePompier"], MesDatas.DsGlobal.Tables["Affectation"].Columns["matriculePompier"], false);
                MesDatas.DsGlobal.Relations.Add("relationPompier2", MesDatas.DsGlobal.Tables["Passer"].Columns["matriculePompier"], MesDatas.DsGlobal.Tables["Pompier"].Columns["matricule"], false);
            }
            MesDatas.DsGlobal.EnforceConstraints = true;


        }

        private void cmbNatureSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodePOstal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //on repercute les changement dans le data set

            //Ajout de la mission dans la tables mission

            MesDatas.DsGlobal.Tables["Mission"].Rows.Add(nMission, dateDeclenchment, DBNull.Value, txtMotif.Text, txtRue.Text,
            txtCodePOstal.Text, txtVille.Text, 0, DBNull.Value, cmbNatureSinistre.SelectedIndex + 1, cmbCaserneAMobiliser.SelectedIndex + 1);

            //On modifie les boléen "en Mission" de la table pompier et engin
            foreach (DataRow row in dtEngin.Rows)
            {
                foreach (DataRow row2 in MesDatas.DsGlobal.Tables["Engin"].Rows)
                {
                    if (Convert.ToInt16(row["numero"]) == Convert.ToInt16(row2["numero"]) && cmbCaserneAMobiliser.SelectedIndex == Convert.ToInt16(row2["idCaserne"]))
                    {
                        row2["enMission"] = 1;
                    }
                }
            }

            foreach (DataRow row in dtPompier.Rows)
            {

                foreach (DataRow row2 in MesDatas.DsGlobal.Tables["Pompier"].Rows)
                {
                    if (Convert.ToInt16(row["matricule"]) == Convert.ToInt16(row2["matricule"]))
                    {
                        row2["enMission"] = 1;
                    }
                }
            }
            
            DataTable dtEngin2  = dtEngin.Copy();
            dtEngin2.TableName = nMission.ToString();
            MessageBox.Show(dtEngin2.TableName);
            MesDatas.DsDtEngin.Tables.Add(dtEngin2);

            DataTable dtPompier2 = dtPompier.Copy();
            dtPompier2.TableName = nMission.ToString();
            MesDatas.DsDtPompier.Tables.Add(dtPompier2);

            Program.tb(this);

        }

        private void lblCodePostal_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearPnl()
        {
            foreach (Control control in plnAffectation.Controls.OfType<Control>().ToList())
            {
                if (!(control is Label))
                {
                    plnAffectation.Controls.Remove(control);
                    control.Dispose(); // Libère les ressources utilisées par le contrôle
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSinistreSAE24_SizeChanged(object sender, EventArgs e)
        {

            
        }
    }
}

