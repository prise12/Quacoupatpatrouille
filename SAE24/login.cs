using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace sae24_gestion_des_pompiers
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_se_connecter_Click(object sender, EventArgs e)
        {
            string mdp = "";
            try
            {
                string requete_mdp = "select mdp from Admin where login = '" + txt_login.Text + "'";
                SQLiteCommand cmd_mdp = new SQLiteCommand(requete_mdp, Connexion.Connec);
                MessageBox.Show(requete_mdp);
                mdp = (string)cmd_mdp.ExecuteScalar();
                if (mdp == txt_mdp.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("mot de passe incorrect");
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (SQLiteException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
