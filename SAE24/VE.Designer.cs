namespace sae24_parcours_equipement
{
    partial class VE
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
            this.cbo_selec_caserne = new System.Windows.Forms.ComboBox();
            this.grp_engin = new System.Windows.Forms.GroupBox();
            this.lbl_afficher_panne = new System.Windows.Forms.Label();
            this.lbl_afficher_mission = new System.Windows.Forms.Label();
            this.lbl_afficher_date = new System.Windows.Forms.Label();
            this.lbl_affiche_num = new System.Windows.Forms.Label();
            this.lbl_panne = new System.Windows.Forms.Label();
            this.lbl_mission = new System.Windows.Forms.Label();
            this.lbl_selec_caserne = new System.Windows.Forms.Label();
            this.lbl_date_reception = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcb_image_engin = new System.Windows.Forms.PictureBox();
            this.btn_debut_liste = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_fin_liste = new System.Windows.Forms.Button();
            this.ucNav1 = new ucNavSae24.ucNav();
            this.grp_engin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image_engin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_selec_caserne
            // 
            this.cbo_selec_caserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_selec_caserne.FormattingEnabled = true;
            this.cbo_selec_caserne.Location = new System.Drawing.Point(110, 74);
            this.cbo_selec_caserne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_selec_caserne.Name = "cbo_selec_caserne";
            this.cbo_selec_caserne.Size = new System.Drawing.Size(141, 24);
            this.cbo_selec_caserne.TabIndex = 0;
            this.cbo_selec_caserne.SelectedIndexChanged += new System.EventHandler(this.cbo_selec_caserne_SelectedIndexChanged);
            // 
            // grp_engin
            // 
            this.grp_engin.BackColor = System.Drawing.Color.Transparent;
            this.grp_engin.Controls.Add(this.lbl_afficher_panne);
            this.grp_engin.Controls.Add(this.lbl_afficher_mission);
            this.grp_engin.Controls.Add(this.lbl_afficher_date);
            this.grp_engin.Controls.Add(this.lbl_affiche_num);
            this.grp_engin.Controls.Add(this.lbl_panne);
            this.grp_engin.Controls.Add(this.lbl_mission);
            this.grp_engin.Controls.Add(this.lbl_selec_caserne);
            this.grp_engin.Controls.Add(this.lbl_date_reception);
            this.grp_engin.Controls.Add(this.lbl_numero);
            this.grp_engin.Controls.Add(this.cbo_selec_caserne);
            this.grp_engin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grp_engin.Location = new System.Drawing.Point(16, 97);
            this.grp_engin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_engin.Name = "grp_engin";
            this.grp_engin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_engin.Size = new System.Drawing.Size(375, 436);
            this.grp_engin.TabIndex = 1;
            this.grp_engin.TabStop = false;
            this.grp_engin.Text = "groupBox1";
            // 
            // lbl_afficher_panne
            // 
            this.lbl_afficher_panne.AutoSize = true;
            this.lbl_afficher_panne.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afficher_panne.Location = new System.Drawing.Point(152, 271);
            this.lbl_afficher_panne.Name = "lbl_afficher_panne";
            this.lbl_afficher_panne.Size = new System.Drawing.Size(61, 22);
            this.lbl_afficher_panne.TabIndex = 13;
            this.lbl_afficher_panne.Text = "label4";
            // 
            // lbl_afficher_mission
            // 
            this.lbl_afficher_mission.AutoSize = true;
            this.lbl_afficher_mission.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afficher_mission.Location = new System.Drawing.Point(152, 237);
            this.lbl_afficher_mission.Name = "lbl_afficher_mission";
            this.lbl_afficher_mission.Size = new System.Drawing.Size(61, 22);
            this.lbl_afficher_mission.TabIndex = 12;
            this.lbl_afficher_mission.Text = "label3";
            // 
            // lbl_afficher_date
            // 
            this.lbl_afficher_date.AutoSize = true;
            this.lbl_afficher_date.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afficher_date.Location = new System.Drawing.Point(216, 199);
            this.lbl_afficher_date.Name = "lbl_afficher_date";
            this.lbl_afficher_date.Size = new System.Drawing.Size(61, 22);
            this.lbl_afficher_date.TabIndex = 11;
            this.lbl_afficher_date.Text = "label2";
            // 
            // lbl_affiche_num
            // 
            this.lbl_affiche_num.AutoSize = true;
            this.lbl_affiche_num.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_affiche_num.Location = new System.Drawing.Point(132, 130);
            this.lbl_affiche_num.Name = "lbl_affiche_num";
            this.lbl_affiche_num.Size = new System.Drawing.Size(61, 22);
            this.lbl_affiche_num.TabIndex = 10;
            this.lbl_affiche_num.Text = "label1";
            // 
            // lbl_panne
            // 
            this.lbl_panne.AutoSize = true;
            this.lbl_panne.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panne.Location = new System.Drawing.Point(46, 271);
            this.lbl_panne.Name = "lbl_panne";
            this.lbl_panne.Size = new System.Drawing.Size(89, 22);
            this.lbl_panne.TabIndex = 9;
            this.lbl_panne.Text = "En panne";
            // 
            // lbl_mission
            // 
            this.lbl_mission.AutoSize = true;
            this.lbl_mission.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mission.Location = new System.Drawing.Point(46, 237);
            this.lbl_mission.Name = "lbl_mission";
            this.lbl_mission.Size = new System.Drawing.Size(100, 22);
            this.lbl_mission.TabIndex = 3;
            this.lbl_mission.Text = "En mission";
            // 
            // lbl_selec_caserne
            // 
            this.lbl_selec_caserne.AutoSize = true;
            this.lbl_selec_caserne.Location = new System.Drawing.Point(106, 54);
            this.lbl_selec_caserne.Name = "lbl_selec_caserne";
            this.lbl_selec_caserne.Size = new System.Drawing.Size(156, 16);
            this.lbl_selec_caserne.TabIndex = 6;
            this.lbl_selec_caserne.Text = "Séléctionnez une caserne:";
            // 
            // lbl_date_reception
            // 
            this.lbl_date_reception.AutoSize = true;
            this.lbl_date_reception.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_reception.Location = new System.Drawing.Point(46, 199);
            this.lbl_date_reception.Name = "lbl_date_reception";
            this.lbl_date_reception.Size = new System.Drawing.Size(164, 22);
            this.lbl_date_reception.TabIndex = 3;
            this.lbl_date_reception.Text = "Date de réception:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(46, 130);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(80, 22);
            this.lbl_numero.TabIndex = 2;
            this.lbl_numero.Text = "numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pcb_image_engin);
            this.groupBox2.Controls.Add(this.btn_debut_liste);
            this.groupBox2.Controls.Add(this.btn_precedent);
            this.groupBox2.Controls.Add(this.btn_suivant);
            this.groupBox2.Controls.Add(this.btn_fin_liste);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(397, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(524, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pcb_image_engin
            // 
            this.pcb_image_engin.Location = new System.Drawing.Point(113, 26);
            this.pcb_image_engin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_image_engin.Name = "pcb_image_engin";
            this.pcb_image_engin.Size = new System.Drawing.Size(309, 309);
            this.pcb_image_engin.TabIndex = 10;
            this.pcb_image_engin.TabStop = false;
            // 
            // btn_debut_liste
            // 
            this.btn_debut_liste.BackColor = System.Drawing.Color.Black;
            this.btn_debut_liste.ForeColor = System.Drawing.Color.White;
            this.btn_debut_liste.Location = new System.Drawing.Point(83, 359);
            this.btn_debut_liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_debut_liste.Name = "btn_debut_liste";
            this.btn_debut_liste.Size = new System.Drawing.Size(87, 28);
            this.btn_debut_liste.TabIndex = 10;
            this.btn_debut_liste.Text = "<<";
            this.btn_debut_liste.UseVisualStyleBackColor = false;
            this.btn_debut_liste.Click += new System.EventHandler(this.btn_debut_liste_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.Black;
            this.btn_precedent.ForeColor = System.Drawing.Color.White;
            this.btn_precedent.Location = new System.Drawing.Point(177, 359);
            this.btn_precedent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(87, 28);
            this.btn_precedent.TabIndex = 9;
            this.btn_precedent.Text = "<";
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.Black;
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.Location = new System.Drawing.Point(272, 359);
            this.btn_suivant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(87, 28);
            this.btn_suivant.TabIndex = 8;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_fin_liste
            // 
            this.btn_fin_liste.BackColor = System.Drawing.Color.Black;
            this.btn_fin_liste.ForeColor = System.Drawing.Color.White;
            this.btn_fin_liste.Location = new System.Drawing.Point(366, 359);
            this.btn_fin_liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fin_liste.Name = "btn_fin_liste";
            this.btn_fin_liste.Size = new System.Drawing.Size(87, 28);
            this.btn_fin_liste.TabIndex = 7;
            this.btn_fin_liste.Text = ">>";
            this.btn_fin_liste.UseVisualStyleBackColor = false;
            this.btn_fin_liste.Click += new System.EventHandler(this.btn_fin_liste_Click);
            // 
            // ucNav1
            // 
            this.ucNav1.BackColor = System.Drawing.Color.Maroon;
            this.ucNav1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucNav1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNav1.Location = new System.Drawing.Point(283, 13);
            this.ucNav1.Margin = new System.Windows.Forms.Padding(4);
            this.ucNav1.Name = "ucNav1";
            this.ucNav1.Size = new System.Drawing.Size(321, 63);
            this.ucNav1.TabIndex = 3;
            // 
            // VE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.pompier_flou;
            this.ClientSize = new System.Drawing.Size(933, 546);
            this.Controls.Add(this.ucNav1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_engin);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VE";
            this.Text = "Visualisation Engins 1a1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_engin.ResumeLayout(false);
            this.grp_engin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_image_engin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_selec_caserne;
        private System.Windows.Forms.GroupBox grp_engin;
        private System.Windows.Forms.Label lbl_date_reception;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_selec_caserne;
        private System.Windows.Forms.Button btn_debut_liste;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_fin_liste;
        private System.Windows.Forms.Label lbl_panne;
        private System.Windows.Forms.Label lbl_mission;
        private System.Windows.Forms.PictureBox pcb_image_engin;
        private System.Windows.Forms.Label lbl_afficher_panne;
        private System.Windows.Forms.Label lbl_afficher_mission;
        private System.Windows.Forms.Label lbl_afficher_date;
        private System.Windows.Forms.Label lbl_affiche_num;
        private ucNavSae24.ucNav ucNav1;
    }
}

