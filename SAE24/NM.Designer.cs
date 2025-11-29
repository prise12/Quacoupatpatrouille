namespace frmSinistreSAE24
{
    partial class frmSinistreSAE24
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
            this.lblNumeroMission = new System.Windows.Forms.Label();
            this.lblDeclencheLe = new System.Windows.Forms.Label();
            this.grpInfoUsager = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePOstal = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.grpDecReg = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConstituerEquipe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCaserneAMobiliser = new System.Windows.Forms.ComboBox();
            this.cmbNatureSinistre = new System.Windows.Forms.ComboBox();
            this.lblPomMob = new System.Windows.Forms.Label();
            this.lblEnMob = new System.Windows.Forms.Label();
            this.plnAffectation = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.userControl11 = new ucNavSae24.ucNav();
            this.grpInfoUsager.SuspendLayout();
            this.grpDecReg.SuspendLayout();
            this.plnAffectation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroMission
            // 
            this.lblNumeroMission.AutoSize = true;
            this.lblNumeroMission.BackColor = System.Drawing.Color.Black;
            this.lblNumeroMission.Location = new System.Drawing.Point(32, 72);
            this.lblNumeroMission.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroMission.Name = "lblNumeroMission";
            this.lblNumeroMission.Size = new System.Drawing.Size(101, 24);
            this.lblNumeroMission.TabIndex = 0;
            this.lblNumeroMission.Text = "Mission n° ";
            this.lblNumeroMission.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDeclencheLe
            // 
            this.lblDeclencheLe.AutoSize = true;
            this.lblDeclencheLe.BackColor = System.Drawing.Color.Transparent;
            this.lblDeclencheLe.Location = new System.Drawing.Point(563, 72);
            this.lblDeclencheLe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeclencheLe.Name = "lblDeclencheLe";
            this.lblDeclencheLe.Size = new System.Drawing.Size(127, 24);
            this.lblDeclencheLe.TabIndex = 1;
            this.lblDeclencheLe.Text = "Déclenché le:";
            this.lblDeclencheLe.Click += new System.EventHandler(this.lblDeclencheLe_Click);
            // 
            // grpInfoUsager
            // 
            this.grpInfoUsager.BackColor = System.Drawing.Color.Transparent;
            this.grpInfoUsager.Controls.Add(this.txtVille);
            this.grpInfoUsager.Controls.Add(this.txtCodePOstal);
            this.grpInfoUsager.Controls.Add(this.txtRue);
            this.grpInfoUsager.Controls.Add(this.lblVille);
            this.grpInfoUsager.Controls.Add(this.lblCodePostal);
            this.grpInfoUsager.Controls.Add(this.lblRue);
            this.grpInfoUsager.Controls.Add(this.label1);
            this.grpInfoUsager.Controls.Add(this.lblMotif);
            this.grpInfoUsager.Controls.Add(this.txtMotif);
            this.grpInfoUsager.ForeColor = System.Drawing.SystemColors.Control;
            this.grpInfoUsager.Location = new System.Drawing.Point(12, 99);
            this.grpInfoUsager.Name = "grpInfoUsager";
            this.grpInfoUsager.Size = new System.Drawing.Size(1205, 227);
            this.grpInfoUsager.TabIndex = 2;
            this.grpInfoUsager.TabStop = false;
            this.grpInfoUsager.Text = "Informations usager";
            this.grpInfoUsager.Enter += new System.EventHandler(this.grpInfoUsager_Enter);
            // 
            // txtVille
            // 
            this.txtVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVille.Location = new System.Drawing.Point(808, 165);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(373, 29);
            this.txtVille.TabIndex = 8;
            // 
            // txtCodePOstal
            // 
            this.txtCodePOstal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodePOstal.Location = new System.Drawing.Point(803, 111);
            this.txtCodePOstal.Name = "txtCodePOstal";
            this.txtCodePOstal.Size = new System.Drawing.Size(100, 29);
            this.txtCodePOstal.TabIndex = 7;
            // 
            // txtRue
            // 
            this.txtRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRue.Location = new System.Drawing.Point(803, 60);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(378, 29);
            this.txtRue.TabIndex = 6;
            // 
            // lblVille
            // 
            this.lblVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(751, 165);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(51, 24);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville:";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(667, 114);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(116, 24);
            this.lblCodePostal.TabIndex = 4;
            this.lblCodePostal.Text = "Code Postal:";
            this.lblCodePostal.Click += new System.EventHandler(this.lblCodePostal_Click);
            // 
            // lblRue
            // 
            this.lblRue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(747, 60);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(50, 24);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresse sinistre";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(16, 33);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(54, 24);
            this.lblMotif.TabIndex = 1;
            this.lblMotif.Text = "Motif:";
            // 
            // txtMotif
            // 
            this.txtMotif.AcceptsReturn = true;
            this.txtMotif.AcceptsTab = true;
            this.txtMotif.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMotif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotif.Location = new System.Drawing.Point(85, 28);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(473, 166);
            this.txtMotif.TabIndex = 0;
            this.txtMotif.Text = "Entrez le motif ici...";
            // 
            // grpDecReg
            // 
            this.grpDecReg.BackColor = System.Drawing.Color.Transparent;
            this.grpDecReg.Controls.Add(this.label3);
            this.grpDecReg.Controls.Add(this.btnConstituerEquipe);
            this.grpDecReg.Controls.Add(this.label2);
            this.grpDecReg.Controls.Add(this.cmbCaserneAMobiliser);
            this.grpDecReg.Controls.Add(this.cmbNatureSinistre);
            this.grpDecReg.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDecReg.Location = new System.Drawing.Point(12, 332);
            this.grpDecReg.Name = "grpDecReg";
            this.grpDecReg.Size = new System.Drawing.Size(1211, 127);
            this.grpDecReg.TabIndex = 3;
            this.grpDecReg.TabStop = false;
            this.grpDecReg.Text = "Decisions du Regulateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(861, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caserne à mobiliser";
            // 
            // btnConstituerEquipe
            // 
            this.btnConstituerEquipe.BackColor = System.Drawing.Color.Black;
            this.btnConstituerEquipe.Location = new System.Drawing.Point(971, 87);
            this.btnConstituerEquipe.Name = "btnConstituerEquipe";
            this.btnConstituerEquipe.Size = new System.Drawing.Size(234, 34);
            this.btnConstituerEquipe.TabIndex = 5;
            this.btnConstituerEquipe.Text = "Constituer équipe";
            this.btnConstituerEquipe.UseVisualStyleBackColor = false;
            this.btnConstituerEquipe.Click += new System.EventHandler(this.btnConstituerEquipe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nature du sinistre";
            // 
            // cmbCaserneAMobiliser
            // 
            this.cmbCaserneAMobiliser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaserneAMobiliser.FormattingEnabled = true;
            this.cmbCaserneAMobiliser.Location = new System.Drawing.Point(1060, 40);
            this.cmbCaserneAMobiliser.Name = "cmbCaserneAMobiliser";
            this.cmbCaserneAMobiliser.Size = new System.Drawing.Size(121, 32);
            this.cmbCaserneAMobiliser.TabIndex = 1;
            // 
            // cmbNatureSinistre
            // 
            this.cmbNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNatureSinistre.FormattingEnabled = true;
            this.cmbNatureSinistre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbNatureSinistre.Location = new System.Drawing.Point(174, 45);
            this.cmbNatureSinistre.Name = "cmbNatureSinistre";
            this.cmbNatureSinistre.Size = new System.Drawing.Size(445, 32);
            this.cmbNatureSinistre.TabIndex = 0;
            this.cmbNatureSinistre.SelectedIndexChanged += new System.EventHandler(this.cmbNatureSinistre_SelectedIndexChanged);
            // 
            // lblPomMob
            // 
            this.lblPomMob.AutoSize = true;
            this.lblPomMob.BackColor = System.Drawing.Color.Salmon;
            this.lblPomMob.Location = new System.Drawing.Point(620, 13);
            this.lblPomMob.Name = "lblPomMob";
            this.lblPomMob.Size = new System.Drawing.Size(174, 24);
            this.lblPomMob.TabIndex = 3;
            this.lblPomMob.Text = "Pompiers Mobilisés";
            // 
            // lblEnMob
            // 
            this.lblEnMob.AutoSize = true;
            this.lblEnMob.BackColor = System.Drawing.Color.Salmon;
            this.lblEnMob.Location = new System.Drawing.Point(23, 13);
            this.lblEnMob.Name = "lblEnMob";
            this.lblEnMob.Size = new System.Drawing.Size(153, 24);
            this.lblEnMob.TabIndex = 2;
            this.lblEnMob.Text = "Engins Mobilisés";
            // 
            // plnAffectation
            // 
            this.plnAffectation.AutoScroll = true;
            this.plnAffectation.BackColor = System.Drawing.Color.Transparent;
            this.plnAffectation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plnAffectation.Controls.Add(this.label5);
            this.plnAffectation.Controls.Add(this.label4);
            this.plnAffectation.Location = new System.Drawing.Point(12, 465);
            this.plnAffectation.Name = "plnAffectation";
            this.plnAffectation.Size = new System.Drawing.Size(1211, 261);
            this.plnAffectation.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(745, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pompiers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(88, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Engins";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmer.Location = new System.Drawing.Point(892, 732);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(331, 34);
            this.btnConfirmer.TabIndex = 8;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Visible = false;
            this.btnConfirmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Maroon;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(458, 6);
            this.userControl11.Margin = new System.Windows.Forms.Padding(6);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(320, 60);
            this.userControl11.TabIndex = 9;
            // 
            // frmSinistreSAE24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.pompier_flou;
            this.ClientSize = new System.Drawing.Size(1235, 778);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.plnAffectation);
            this.Controls.Add(this.grpDecReg);
            this.Controls.Add(this.grpInfoUsager);
            this.Controls.Add(this.lblDeclencheLe);
            this.Controls.Add(this.lblNumeroMission);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSinistreSAE24";
            this.Text = "Gestion d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.frmSinistreSAE24_Load);
            this.SizeChanged += new System.EventHandler(this.frmSinistreSAE24_SizeChanged);
            this.grpInfoUsager.ResumeLayout(false);
            this.grpInfoUsager.PerformLayout();
            this.grpDecReg.ResumeLayout(false);
            this.grpDecReg.PerformLayout();
            this.plnAffectation.ResumeLayout(false);
            this.plnAffectation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMission;
        private System.Windows.Forms.Label lblDeclencheLe;
        private System.Windows.Forms.GroupBox grpInfoUsager;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePOstal;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.GroupBox grpDecReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCaserneAMobiliser;
        private System.Windows.Forms.ComboBox cmbNatureSinistre;
        private System.Windows.Forms.Button btnConstituerEquipe;
        private System.Windows.Forms.Label lblEnMob;
        private System.Windows.Forms.Label lblPomMob;
        private System.Windows.Forms.Panel plnAffectation;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ucNavSae24.ucNav userControl11;
    }
}

