using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Pinpon;
using ucTBMission;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.parser;
using ucNavSae24;

namespace frmSinistreSAE24
{
    public partial class TB : Form
    {

        public TB()
        {
            InitializeComponent();
        }

        private void TB_Load(object sender, EventArgs e)
        {
            lblX.Select();

           txtRechercher_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
        }

        private void lblTB_Click(object sender, EventArgs e)
        {

        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            pnlMission.Controls.Clear();
            int i = 0;
            int j = 0;
            int k = 1;
            foreach (DataRow row in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {

                //pour la recherche suprime tout éspace et on mes les deux string en minuscule 
                if ((row["motifAppel"].ToString().ToLower().Contains(txtRechercher.Text.ToLower()) || txtRechercher.Text == "Rechercher...") )
                {
                    if (!chkEnCours.Checked || Convert.ToInt16(row["terminee"]) == 0)
                    {
                        if (i == 2)
                        {
                            i = 0;
                            j++;
                        }

                        string sinistre = "";   
                        foreach (DataRow row2 in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
                        {
                            if (Convert.ToInt16(row2["id"]) == Convert.ToInt16(row["idNatureSinistre"]))
                            {
                                sinistre = row2["libelle"].ToString();
                            }
                        }

                        ucTbMission ucMission = new ucTbMission(row, sinistre);
                        pnlMission.Controls.Add(ucMission);
                        ucMission.Location = new System.Drawing.Point(20 + 480 * i, 15 + 160 * j);
                        ucMission.btnCloturer_ += new System.EventHandler(this.btnCloturer_Click);
                        ucMission.btnPDF_ += new System.EventHandler(this.btnPDF_Click);
                        ucMission.Tag = k;
                        i++;
                        k++;
                    }
                }
            }

        }


        //afficher un "place holder"
        private void txtRechercher_Enter(object sender, EventArgs e)
        {
            if (txtRechercher.Text == "Rechercher...")
            {
                txtRechercher.Text = "";
                txtRechercher.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtRechercher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRechercher.Text))
            {
                txtRechercher.Text = "Rechercher...";
                txtRechercher.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            txtRechercher_TextChanged(sender, e);
        }

        private void ucTbMission1_Load(object sender, EventArgs e)
        {
        }

        private void btnCloturer_Click(object sender, EventArgs e)
        {
            ucTbMission uc = (ucTbMission)sender;

            //on verifie si la table existe deja si c'est le cas alors uniquement le booleen terminee de la table mission est changé
            bool MissionExiste = false;
            string requete = "Select id from Mission";
            SQLiteCommand cmd = new SQLiteCommand(requete,Connexion.Connec);
            SQLiteDataReader r = cmd.ExecuteReader();
            String id;
            uc.RowMission["terminee"] = 1;
            while (r.Read()) 
            {
                id = r["id"].ToString();
                if (id == uc.Tag.ToString()) { MissionExiste = true; break; }

            }
                string escapeSingleQuotesorNull(string value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        return "NULL";
                    }
                    return value.Replace("'", "''");
                }
                //on met à jour notre base de donnée
                //table mission
                string id1 = uc.RowMission["id"].ToString();
                string dateHeureDepart = uc.RowMission["dateHeureDepart"].ToString();
                string motifAppel = escapeSingleQuotesorNull(uc.RowMission["motifAppel"].ToString());
                string adresse = escapeSingleQuotesorNull(uc.RowMission["adresse"].ToString());
                string cp = uc.RowMission["cp"].ToString();
                string ville = escapeSingleQuotesorNull(uc.RowMission["ville"].ToString());
                string compteRendu = escapeSingleQuotesorNull(uc.RowMission["compteRendu"].ToString());
                string idNatureSinistre = uc.RowMission["idNatureSinistre"].ToString();
                string idCaserne = uc.RowMission["idCaserne"].ToString();

                requete = $"INSERT INTO Mission VALUES ({id1 + 1 }, '{dateHeureDepart}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{motifAppel}', '{adresse}', '{cp}', '{ville}', 1, {compteRendu}, {idNatureSinistre}, {idCaserne})";
                if (!MissionExiste)
                {//table PartirAvec
                    SQLiteCommand cmd2 = new SQLiteCommand(requete, Connexion.Connec);
                    cmd2.ExecuteNonQuery();

               
                    foreach (DataRow row in MesDatas.DsDtEngin.Tables[uc.Tag.ToString()].Rows)
                    {
                        String requete1 = "INSERT INTO PartirAvec (idCaserne,codeTypeEngin,numeroEngin,idMission) VALUES ('" + uc.RowMission["idCaserne"].ToString() + "','" + row["codeTypeEngin"].ToString() + "','" + row["numero"]
                            + "','" + uc.Tag.ToString() + "')";

                        SQLiteCommand cmd1 = new SQLiteCommand(requete1, Connexion.Connec);
                        cmd1.ExecuteNonQuery();
                    }

                    //table PartirAvec
                    foreach (DataRow row in MesDatas.DsDtPompier.Tables[uc.Tag.ToString()].Rows)
                    {
                        String requete1 = "INSERT INTO Mobiliser  (matriculePompier,idMission,idHabilitation )  VALUES ('" + row["matricule"].ToString() + "','" + uc.Tag.ToString() + "','" + row["habilitation"] + "')";

                        SQLiteCommand cmd1 = new SQLiteCommand(requete1, Connexion.Connec);
                        cmd1.ExecuteNonQuery();
                    }
                }
                if (MissionExiste)
                {
                    string updateRequete = $"UPDATE Mission SET terminee = 1 WHERE id = {uc.Tag.ToString()}";
                    SQLiteCommand updateCmd = new SQLiteCommand(updateRequete, Connexion.Connec);
                    updateCmd.ExecuteNonQuery();
                }

            txtRechercher_TextChanged(this, e);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

            ucTbMission uc = (ucTbMission)sender;

            Document doc = new Document(PageSize.A4);
            string chemin = "RapportMission"+ uc.Tag.ToString()+".pdf";
            PdfWriter.GetInstance(doc, new FileStream(chemin, FileMode.Create));

            doc.Open();

            // Police par défaut
            BaseFont basefont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            // Police pour les titres
            iTextSharp.text.Font titreFont = new iTextSharp.text.Font(basefont, 25, iTextSharp.text.Font.BOLD);
            titreFont.SetStyle(iTextSharp.text.Font.UNDERLINE);

            // Police pour les textes en gras
            iTextSharp.text.Font grasFont = new iTextSharp.text.Font(basefont, 15, iTextSharp.text.Font.BOLD);

            // On ajoute le titre du document comportant le numéro de celle-ci
            Paragraph titre = new Paragraph("Rapport de la mission n°" + (Convert.ToInt16(uc.Tag)).ToString(), titreFont);
            titre.Alignment = Element.ALIGN_CENTER;
            doc.Add(titre);
            doc.Add(new Paragraph("\n\n"));

            DateTime dateDebut = Convert.ToDateTime(uc.RowMission["dateHeureDepart"]);
            doc.Add(new Paragraph("Déclenchée le : " + dateDebut.ToString("dd/MM/yyyy") + " à " + dateDebut.ToString("HH:mm")));

            DateTime dateFin = Convert.ToDateTime(uc.RowMission["dateHeureRetour"]);
            doc.Add(new Paragraph("Retour le : " + dateFin.ToString("dd/MM/yyyy") + " à " + dateFin.ToString("HH:mm")));

            doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("\n\n"));

            string sinistre = "";
            foreach (DataRow row2 in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
            {
                if (Convert.ToInt16(row2["id"]) == Convert.ToInt16(uc.RowMission["idNatureSinistre"]))
                {
                    sinistre = row2["libelle"].ToString();
                }
            }

            doc.Add(new Paragraph("Type de sinistre : " +sinistre, titreFont));
            doc.Add(new Paragraph("Motif : " + uc.RowMission["motifAppel"], grasFont));
            doc.Add(new Paragraph("Adresse : " + uc.RowMission["adresse"] +" "+ uc.RowMission["cp"] +" "+ uc.RowMission["ville"], grasFont));
            doc.Add(new Paragraph("Compte-rendu : " + uc.RowMission["CompteRendu"], grasFont));

            doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("\n\n"));


            //Engins AFFECTES
            doc.Add(new Paragraph("Engins affectés : " + sinistre, titreFont));
            doc.Add(new Paragraph("\n"));
            String requete = "Select * from PartirAvec Where idMission = " + uc.Tag.ToString();
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader row = cmd.ExecuteReader();

            while (row.Read())
            {
                String codeTypeEngin = row["codeTypeEngin"].ToString();
                String requete1 = "Select nom from TypeEngin Where code = '" + codeTypeEngin + "'";
                SQLiteCommand cmd1 = new SQLiteCommand(requete1, Connexion.Connec);
                String r1 = cmd1.ExecuteScalar().ToString();
                String reparation = row["reparationsEventuelles"]?.ToString();
                if (string.IsNullOrEmpty(reparation))
                {
                    reparation = "pas de réparations prévues";
                }
                doc.Add(new Paragraph("--> : " + r1 + " " + row["idCaserne"] + "-" + codeTypeEngin + "-" + row["numeroEngin"] + " (" + reparation + ")"));
                doc.Add(new Paragraph("\n"));
            }

            row.Close();
            doc.Add(new Paragraph("\n"));

            //Pompier AFFECTES
            doc.Add(new Paragraph("Pompier affectés : " + sinistre, titreFont));
            doc.Add(new Paragraph("\n"));
            String requete3 = "Select * from Mobiliser Where idMission = " + uc.Tag.ToString();
            SQLiteCommand cmd3 = new SQLiteCommand(requete3, Connexion.Connec);
            SQLiteDataReader row3 = cmd3.ExecuteReader();
            while (row3.Read())
            { 
                String requete4 = "Select g.libelle, p.nom, p.prenom from Grade g, Pompier p Where p.codeGrade = g.code and p.matricule = " + row3["matriculePompier"];
                String requete5 = "Select libelle from Habilitation Where id = " + row3["idHabilitation"].ToString();

                SQLiteCommand cmd1 = new SQLiteCommand(requete4, Connexion.Connec);
                SQLiteDataReader r1 = cmd1.ExecuteReader();
                SQLiteCommand cmd2 = new SQLiteCommand(requete5, Connexion.Connec);
                String r2 = cmd2.ExecuteScalar().ToString();
                if (r1.Read())
                {
                    doc.Add(new Paragraph("--> : " + r1["libelle"] + " " + r1["nom"] + " " + r1["prenom"] + " (" + r2 + ")"));
                    doc.Add(new Paragraph("\n"));
                }
            }
            row.Close();
    

            doc.Close();

            Process.Start(new ProcessStartInfo(chemin) { UseShellExecute = true });
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnTb_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                TB nouveauFormulaire = new TB();
                nouveauFormulaire.Show();
            }));
            this.Close();
        }

        private void ucNav1_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
