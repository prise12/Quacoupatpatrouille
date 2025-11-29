using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ucNouvelleMissionEnginsSae24;
using Pinpon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ucNavSae24;
using ucNouvelleMissionPompierSae24;

namespace sae24_statistiques_vrai
{
    public partial class ST : Form
    {
        public ST()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //remplissage cbo caserne
            string requete = "select nom from Caserne";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                string caserne = drd["nom"].ToString();
                cbo_selec_caserne.Items.Add(caserne);
            }
            drd.Close();

            //remplissage cbo habilitation
            string requete_hab = "select libelle from Habilitation";
            SQLiteCommand cmd_hab = new SQLiteCommand(requete_hab, Connexion.Connec);
            SQLiteDataReader drd_hab = cmd_hab.ExecuteReader();
            while (drd_hab.Read())
            {
                string hab = drd_hab["libelle"].ToString();
                cbo_selection_habilitation.Items.Add(hab);
            }

            //habilitations les plus sollicitées
            string requete_top_hab = "select libelle,count(idHabilitation) nb_sollicitations from Mobiliser m join Habilitation h on m.idHabilitation = h.id group by libelle order by nb_sollicitations DESC";
            SQLiteCommand cmd_top_hab = new SQLiteCommand(requete_top_hab, Connexion.Connec);
            SQLiteDataReader drd_top_hab = cmd_top_hab.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(drd_top_hab);
            dgv_top_hab.DataSource = dataTable;

            //interventions par sinistre
            string requete_interventions_sinistre = "select n.libelle, count(m.id) as nb_interventions from Mission m join NatureSinistre n on m.idNatureSinistre = n.id group by m.idNatureSinistre order by nb_interventions DESC";
            SQLiteCommand cmd_intervetions_sinistre = new SQLiteCommand(requete_interventions_sinistre, Connexion.Connec);
            SQLiteDataReader drd_interventions_sinistre =cmd_intervetions_sinistre.ExecuteReader();

            DataTable dataTable2 = new DataTable();
            dataTable2.Load(drd_interventions_sinistre);
            dgv_interventions_par_sinistre.DataSource = dataTable2;
        }

        private void cbo_selec_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbcEngin.TabPages[0].Controls.Clear();
            tbcEngin.TabPages[1].Controls.Clear();
            string requete_top_hab = "select E.numero, e.codeTypeEngin , sum((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24) as nbHeures from Engin e join PartirAvec p on  e.idCaserne = p.idCaserne and e.codeTypeEngin = p.codeTypeEngin and e.numero = p.numeroEngin join Mission m  on p.idMission = m.id where m.id = p.idMission and m.idCaserne ="+(cbo_selec_caserne.SelectedIndex+1)+" group by e.codeTypeEngin, e.numero order by nbHeures DESC\r\n";
            SQLiteCommand cmd_top_hab = new SQLiteCommand(requete_top_hab, Connexion.Connec);
            SQLiteDataReader drd_top_hab = cmd_top_hab.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(drd_top_hab);

            //requete pour le top3
            string requete_top_3 = "select E.numero, e.codeTypeEngin , sum((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24) as nbHeures from Engin e join PartirAvec p on  e.idCaserne = p.idCaserne and e.codeTypeEngin = p.codeTypeEngin and e.numero = p.numeroEngin join Mission m  on p.idMission = m.id where m.id = p.idMission and m.idCaserne =" + (cbo_selec_caserne.SelectedIndex + 1) + " group by e.codeTypeEngin, e.numero order by nbHeures DESC limit 3";
            SQLiteCommand cmd_top_3 = new SQLiteCommand(requete_top_3, Connexion.Connec);
            SQLiteDataReader drd_top_3 = cmd_top_3.ExecuteReader();

            DataTable dataTable3 = new DataTable();
            dataTable3.Load(drd_top_3);
            int i = 0;
            Font ucfont = new Font(this.Font.FontFamily, 8f, this.Font.Style);
            ajouterUcTabEngin(dataTable, tbcEngin.TabPages[1], cbo_selec_caserne.SelectedIndex, ucfont);
            ajouterUcTabEngin(dataTable3, tbcEngin.TabPages[0], cbo_selec_caserne.SelectedIndex, ucfont);
        }
        private void ajouterUcTabEngin(DataTable table, TabPage page, int idCaserne, Font font)
        {
            int y = 24;
            foreach (DataRow row in table.Rows)
            {
                foreach (DataRow enginRow in MesDatas.DsGlobal.Tables["Engin"].Rows)
                {
                    if (Convert.ToInt16( enginRow["idCaserne"]) == idCaserne &&
                        enginRow["numero"].ToString() == row["numero"].ToString() &&
                        enginRow["codeTypeEngin"].ToString() == row["codeTypeEngin"].ToString())
                    {
                        var uc = new ucEngindNM(enginRow);
                        if (row[2] != DBNull.Value)
                        {
                            String nbHeure = "heure:\n" + Convert.ToInt16(row[2]) + " h";
                            uc = new ucEngindNM(enginRow, nbHeure);
                        }
                        uc.Location = new Point(40, 24 + y);
                        uc.Font = font;

                        page.Controls.Add(uc);
                        y += 100;
                        break;
                    }
                }
            }
        }

        private void cbo_selection_habilitation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remplissage cbo caserne
            string requete = @"
                SELECT DISTINCT p.matricule, pa.idHabilitation
                FROM Pompier p
                JOIN Passer pa ON p.matricule = pa.matriculePompier
                JOIN Habilitation h ON pa.idHabilitation = h.id
                WHERE h.libelle = '" + cbo_selection_habilitation.SelectedItem + "'";
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader drd3 = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(drd3);
            Font ucfont = new Font(this.Font.FontFamily, 7f, this.Font.Style);
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataRow pompierRow in MesDatas.DsGlobal.Tables["Pompier"].Rows)
                {
                    if (pompierRow["matricule"].ToString() == row[0].ToString())
                    {
                        ucNouvelleMissionPompierSae24.UserControl1 uc = new ucNouvelleMissionPompierSae24.UserControl1(pompierRow, cbo_selection_habilitation.SelectedItem.ToString().Substring(0,3));
                        uc.Location = new Point(15, 16 + i);
                        uc.Font = ucfont;

                        pnlPompier.Controls.Add(uc);
                        i += 80;
                        break;
                    }
                }
            }
        }

        private void pnlPompier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_interventions_par_sinistre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
