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

namespace sae24_parcours_equipement
{

    public partial class VE : Form
    {
        public VE()
        {
            InitializeComponent();
        }
        BindingSource bsCaserne = new BindingSource();
        BindingSource bsEngin;


        private void Form1_Load(object sender, EventArgs e)
        {
            string requete = "select * from Engin";
            SQLiteCommand cd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
            da.Fill(MesDatas.DsGlobal, "Engin");

            string requete_caserne = "select * from Caserne";
            SQLiteCommand cd2 = new SQLiteCommand(requete_caserne, Connexion.Connec);
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(cd2);
            da2.Fill(MesDatas.DsGlobal, "Caserne");

            //BINDING SOURCES ET DATASOURCES


            DataRelation rel = new DataRelation("relCaserneEngin",
                    MesDatas.DsGlobal.Tables["Caserne"].Columns["id"],
                    MesDatas.DsGlobal.Tables["Engin"].Columns["idCaserne"]);
            MesDatas.DsGlobal.Relations.Add(rel);

            
            bsCaserne.DataSource = MesDatas.DsGlobal;
            bsCaserne.DataMember = "Caserne";

            bsEngin = new BindingSource(bsCaserne, "relCaserneEngin");

            cbo_selec_caserne.DataSource = bsCaserne;
            cbo_selec_caserne.DisplayMember = "nom";

            lbl_affiche_num.DataBindings.Add("Text", bsEngin,"codeTypeEngin");
            lbl_afficher_date.DataBindings.Add("Text", bsEngin, "dateReception");
            lbl_afficher_panne.DataBindings.Add("Text", bsEngin, "enPanne");
            lbl_afficher_mission.DataBindings.Add("Text", bsEngin, "enMission");

            ImageEngin();
            EnMissionEnPanne();
        }

        private void cbo_selec_caserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbo_selec_caserne.SelectedIndex;
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            bsEngin.Position += 1;
            ImageEngin();
            EnMissionEnPanne();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            bsEngin.Position -= 1;
            ImageEngin();
            EnMissionEnPanne();
        }

        private void btn_fin_liste_Click(object sender, EventArgs e)
        {
            bsEngin.MoveLast();
            ImageEngin();
            EnMissionEnPanne();
        }

        private void btn_debut_liste_Click(object sender, EventArgs e)
        {
            bsEngin.MoveFirst();
            ImageEngin();
            EnMissionEnPanne();
        }

        public void ImageEngin() 
        {

            string extension = ".png";
            string chemin = "imageEngins/"+lbl_affiche_num.Text+extension;
            //MessageBox.Show(chemin);
            pcb_image_engin.Image = Image.FromFile(chemin);
            pcb_image_engin.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void EnMissionEnPanne() 
        {
            if (lbl_afficher_mission.Text.Length > 0)
            {
                if(lbl_afficher_mission.Text == "1") 
                {
                    lbl_afficher_mission.Text = "Oui";
                }
                else 
                {
                    lbl_afficher_mission.Text = "Non";
                }
            }
            if (lbl_afficher_panne.Text.Length > 0)
            {
                if (lbl_afficher_panne.Text == "1")
                {
                    lbl_afficher_panne.Text = "Oui";
                }
                else
                {
                    lbl_afficher_panne.Text = "Non";
                }
            }
        }
    }


    internal class Connexion
    {
        // Objet Connection
        private static SQLiteConnection connec;

        // Constructeur privé pour empêcher l'instanciation directe depuis l'extérieur.
        private Connexion() { }

        // Méthode publique pour obtenir l'instance unique de la classe.
        public static SQLiteConnection Connec
        {
            get
            {
                // Si l'instance n'existe pas, on la crée.
                if (connec == null)
                {
                    try
                    {
                        // Chaîne de connexion à votre base de données
                        string chaine = @"Data Source = SDIS67.db";
                        connec = new SQLiteConnection(chaine);
                        connec.Open();
                    }
                    catch (SQLiteException err)
                    {
                        Console.WriteLine($"Erreur lors de l'ouverture de la connexion : {err.Message}");
                    }
                }
                //Dans tous les cas on renvoie la connexion
                return connec;
            }
        }

        // Méthode pour fermer proprement la connexion
        public static void FermerConnexion()
        {
            if (connec != null)
            {
                try
                {
                    connec.Close();
                    connec.Dispose();
                    connec = null; // Libération pour permettre une nouvelle connexion propre
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Erreur lors de la fermeture de la connexion : {err.Message}");
                }
            }
        }
    }

    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();

        public static DataSet DsGlobal { get { return MesDatas.dsGlobal; } }

    }
}

