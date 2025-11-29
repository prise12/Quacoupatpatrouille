using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmSinistreSAE24;
using sae24_parcours_equipement;

namespace ucNavSae24
{
    public partial class ucNav : UserControl
    {
        
        public ucNav()
        {
            InitializeComponent();
        }

        public TB tb;
        public frmSinistreSAE24.frmSinistreSAE24 nm;

        private void UserControl1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnTb_Click(object sender, EventArgs e)
        {
            Program.tb(this.ParentForm);

        }

        private void btnNm_Click(object sender, EventArgs e)
        {
            Program.nm(this.ParentForm);

        }

        private void btnVe_Click_1(object sender, EventArgs e)
        {
            Program.ve(this.ParentForm);

        }

        private void btnGp_Click(object sender, EventArgs e)
        {
            Program.gp(this.ParentForm);
        }

        private void btnSt_Click(object sender, EventArgs e)
        {
            Program.st(this.ParentForm);
        }
    }
}
