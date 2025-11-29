namespace frmSinistreSAE24
{
    partial class TB
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.pnlMission = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.ucNav1 = new ucNavSae24.ucNav();
            this.SuspendLayout();
            // 
            // txtRechercher
            // 
            this.txtRechercher.ForeColor = System.Drawing.Color.Gray;
            this.txtRechercher.Location = new System.Drawing.Point(236, 94);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(192, 31);
            this.txtRechercher.TabIndex = 0;
            this.txtRechercher.Text = "Rechercher...";
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
            this.txtRechercher.Leave += new System.EventHandler(this.txtRechercher_Leave);
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.BackColor = System.Drawing.Color.Transparent;
            this.chkEnCours.Location = new System.Drawing.Point(875, 98);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(116, 29);
            this.chkEnCours.TabIndex = 4;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = false;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.BackColor = System.Drawing.Color.Transparent;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Location = new System.Drawing.Point(6, 91);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(225, 31);
            this.lblTB.TabIndex = 5;
            this.lblTB.Text = "Tableau de bord";
            this.lblTB.Click += new System.EventHandler(this.lblTB_Click);
            // 
            // pnlMission
            // 
            this.pnlMission.AutoScroll = true;
            this.pnlMission.BackColor = System.Drawing.Color.Transparent;
            this.pnlMission.Location = new System.Drawing.Point(12, 133);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(979, 524);
            this.pnlMission.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(745, 26);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 25);
            this.lblX.TabIndex = 7;
            // 
            // ucNav1
            // 
            this.ucNav1.BackColor = System.Drawing.Color.Maroon;
            this.ucNav1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucNav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNav1.Location = new System.Drawing.Point(331, 12);
            this.ucNav1.Name = "ucNav1";
            this.ucNav1.Size = new System.Drawing.Size(320, 68);
            this.ucNav1.TabIndex = 9;
            this.ucNav1.Click += new System.EventHandler(this.ucNav1_Click);
            // 
            // TB
            // 
            this.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.pompier_flou;
            this.ClientSize = new System.Drawing.Size(1003, 669);
            this.Controls.Add(this.ucNav1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.pnlMission);
            this.Controls.Add(this.chkEnCours);
            this.Controls.Add(this.txtRechercher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TB";
            this.Load += new System.EventHandler(this.TB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Panel pnlMission;
        private System.Windows.Forms.Label lblX;
        private ucNavSae24.ucNav ucNav1;
    }
}

#endregion