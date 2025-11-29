using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sae24_gestion_des_pompiers;
using sae24_parcours_equipement;
using sae24_statistiques_vrai;

namespace frmSinistreSAE24
{
    public static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TB());
        }
        public static void tb(Form frm)
        {
            frm.Hide();
            TB tb = new TB();
            tb.FormClosed += (s, e) => frm.Close(); 
            tb.Show();
            //frm.Close();
        }

        public static void nm(Form frm)
        {
            frm.Hide();
            frmSinistreSAE24 tb = new frmSinistreSAE24();
            tb.FormClosed += (s, e) => frm.Close(); 
            tb.Show();
            //frm.Close();
        }
        public static void ve(Form frm)
        {
            frm.Hide();
            VE tb = new VE();
            tb.FormClosed += (s, e) => frm.Close(); 
            tb.Show();
            //frm.Close();
        }
        public static void gp(Form frm)
        {
            frm.Hide();
            sae24_gestion_des_pompiers.Form1 tb = new sae24_gestion_des_pompiers.Form1();
            tb.FormClosed += (s, e) => frm.Close();
            tb.Show();
            //frm.Close();
        }
        public static void st(Form frm)
        {
            frm.Hide();
            ST tb = new ST();
            tb.FormClosed += (s, e) => frm.Close();
            tb.Show();
            //frm.Close();
        }

    }

    
}
