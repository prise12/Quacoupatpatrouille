namespace sae24_statistiques_vrai
{
    partial class ST
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
            this.grp_stats_par_caserne = new System.Windows.Forms.GroupBox();
            this.tbcEngin = new System.Windows.Forms.TabControl();
            this.p1 = new System.Windows.Forms.TabPage();
            this.p2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_selec_caserne = new System.Windows.Forms.ComboBox();
            this.grp_stats_toutes_casernes = new System.Windows.Forms.GroupBox();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.dgv_interventions_par_sinistre = new System.Windows.Forms.DataGridView();
            this.dgv_top_hab = new System.Windows.Forms.DataGridView();
            this.lbl_selec_hab = new System.Windows.Forms.Label();
            this.cbo_selection_habilitation = new System.Windows.Forms.ComboBox();
            this.ucNav1 = new ucNavSae24.ucNav();
            this.grp_stats_par_caserne.SuspendLayout();
            this.tbcEngin.SuspendLayout();
            this.grp_stats_toutes_casernes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interventions_par_sinistre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_hab)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_stats_par_caserne
            // 
            this.grp_stats_par_caserne.BackColor = System.Drawing.Color.Transparent;
            this.grp_stats_par_caserne.Controls.Add(this.tbcEngin);
            this.grp_stats_par_caserne.Controls.Add(this.label1);
            this.grp_stats_par_caserne.Controls.Add(this.cbo_selec_caserne);
            this.grp_stats_par_caserne.ForeColor = System.Drawing.Color.White;
            this.grp_stats_par_caserne.Location = new System.Drawing.Point(12, 110);
            this.grp_stats_par_caserne.Name = "grp_stats_par_caserne";
            this.grp_stats_par_caserne.Size = new System.Drawing.Size(484, 517);
            this.grp_stats_par_caserne.TabIndex = 0;
            this.grp_stats_par_caserne.TabStop = false;
            this.grp_stats_par_caserne.Text = "Statistiques pour la caserne:";
            // 
            // tbcEngin
            // 
            this.tbcEngin.Controls.Add(this.p1);
            this.tbcEngin.Controls.Add(this.p2);
            this.tbcEngin.Location = new System.Drawing.Point(6, 98);
            this.tbcEngin.Name = "tbcEngin";
            this.tbcEngin.SelectedIndex = 0;
            this.tbcEngin.Size = new System.Drawing.Size(472, 413);
            this.tbcEngin.TabIndex = 4;
            // 
            // p1
            // 
            this.p1.AutoScroll = true;
            this.p1.Location = new System.Drawing.Point(4, 22);
            this.p1.Name = "p1";
            this.p1.Padding = new System.Windows.Forms.Padding(3);
            this.p1.Size = new System.Drawing.Size(464, 387);
            this.p1.TabIndex = 0;
            this.p1.Text = "Engins les plus utilisé";
            this.p1.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.AutoScroll = true;
            this.p2.Location = new System.Drawing.Point(4, 22);
            this.p2.Name = "p2";
            this.p2.Padding = new System.Windows.Forms.Padding(3);
            this.p2.Size = new System.Drawing.Size(464, 387);
            this.p2.TabIndex = 1;
            this.p2.Text = "Nombre d\'heure de chaque engins";
            this.p2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Séléctionnez une caserne:";
            // 
            // cbo_selec_caserne
            // 
            this.cbo_selec_caserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_selec_caserne.FormattingEnabled = true;
            this.cbo_selec_caserne.Location = new System.Drawing.Point(182, 65);
            this.cbo_selec_caserne.Name = "cbo_selec_caserne";
            this.cbo_selec_caserne.Size = new System.Drawing.Size(121, 21);
            this.cbo_selec_caserne.TabIndex = 2;
            this.cbo_selec_caserne.SelectedIndexChanged += new System.EventHandler(this.cbo_selec_caserne_SelectedIndexChanged);
            // 
            // grp_stats_toutes_casernes
            // 
            this.grp_stats_toutes_casernes.BackColor = System.Drawing.Color.Transparent;
            this.grp_stats_toutes_casernes.Controls.Add(this.pnlPompier);
            this.grp_stats_toutes_casernes.Controls.Add(this.dgv_interventions_par_sinistre);
            this.grp_stats_toutes_casernes.Controls.Add(this.dgv_top_hab);
            this.grp_stats_toutes_casernes.Controls.Add(this.lbl_selec_hab);
            this.grp_stats_toutes_casernes.Controls.Add(this.cbo_selection_habilitation);
            this.grp_stats_toutes_casernes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grp_stats_toutes_casernes.Location = new System.Drawing.Point(502, 110);
            this.grp_stats_toutes_casernes.Name = "grp_stats_toutes_casernes";
            this.grp_stats_toutes_casernes.Size = new System.Drawing.Size(460, 517);
            this.grp_stats_toutes_casernes.TabIndex = 1;
            this.grp_stats_toutes_casernes.TabStop = false;
            this.grp_stats_toutes_casernes.Text = "Statistiques toutes casernes confondues:";
            // 
            // pnlPompier
            // 
            this.pnlPompier.AutoScroll = true;
            this.pnlPompier.Location = new System.Drawing.Point(6, 296);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(448, 215);
            this.pnlPompier.TabIndex = 10;
            this.pnlPompier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPompier_Paint);
            // 
            // dgv_interventions_par_sinistre
            // 
            this.dgv_interventions_par_sinistre.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_interventions_par_sinistre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_interventions_par_sinistre.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_interventions_par_sinistre.Location = new System.Drawing.Point(6, 19);
            this.dgv_interventions_par_sinistre.Name = "dgv_interventions_par_sinistre";
            this.dgv_interventions_par_sinistre.Size = new System.Drawing.Size(448, 120);
            this.dgv_interventions_par_sinistre.TabIndex = 9;
            this.dgv_interventions_par_sinistre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_interventions_par_sinistre_CellContentClick);
            // 
            // dgv_top_hab
            // 
            this.dgv_top_hab.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_top_hab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_top_hab.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_top_hab.Location = new System.Drawing.Point(6, 145);
            this.dgv_top_hab.Name = "dgv_top_hab";
            this.dgv_top_hab.Size = new System.Drawing.Size(448, 102);
            this.dgv_top_hab.TabIndex = 2;
            // 
            // lbl_selec_hab
            // 
            this.lbl_selec_hab.AutoSize = true;
            this.lbl_selec_hab.Location = new System.Drawing.Point(154, 253);
            this.lbl_selec_hab.Name = "lbl_selec_hab";
            this.lbl_selec_hab.Size = new System.Drawing.Size(145, 13);
            this.lbl_selec_hab.TabIndex = 8;
            this.lbl_selec_hab.Text = "Séléctionnez une habilitation:";
            // 
            // cbo_selection_habilitation
            // 
            this.cbo_selection_habilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_selection_habilitation.FormattingEnabled = true;
            this.cbo_selection_habilitation.Location = new System.Drawing.Point(168, 269);
            this.cbo_selection_habilitation.Name = "cbo_selection_habilitation";
            this.cbo_selection_habilitation.Size = new System.Drawing.Size(121, 21);
            this.cbo_selection_habilitation.TabIndex = 6;
            this.cbo_selection_habilitation.SelectedIndexChanged += new System.EventHandler(this.cbo_selection_habilitation_SelectedIndexChanged);
            // 
            // ucNav1
            // 
            this.ucNav1.BackColor = System.Drawing.Color.Maroon;
            this.ucNav1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucNav1.Location = new System.Drawing.Point(337, 12);
            this.ucNav1.Name = "ucNav1";
            this.ucNav1.Size = new System.Drawing.Size(320, 60);
            this.ucNav1.TabIndex = 2;
            // 
            // ST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.pompier_flou;
            this.ClientSize = new System.Drawing.Size(974, 639);
            this.Controls.Add(this.ucNav1);
            this.Controls.Add(this.grp_stats_toutes_casernes);
            this.Controls.Add(this.grp_stats_par_caserne);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ST";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_stats_par_caserne.ResumeLayout(false);
            this.grp_stats_par_caserne.PerformLayout();
            this.tbcEngin.ResumeLayout(false);
            this.grp_stats_toutes_casernes.ResumeLayout(false);
            this.grp_stats_toutes_casernes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interventions_par_sinistre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top_hab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_stats_par_caserne;
        private System.Windows.Forms.ComboBox cbo_selec_caserne;
        private System.Windows.Forms.GroupBox grp_stats_toutes_casernes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_selection_habilitation;
        private System.Windows.Forms.Label lbl_selec_hab;
        private System.Windows.Forms.DataGridView dgv_top_hab;
        private System.Windows.Forms.DataGridView dgv_interventions_par_sinistre;
        private ucNavSae24.ucNav ucNav1;
        private System.Windows.Forms.TabControl tbcEngin;
        private System.Windows.Forms.TabPage p1;
        private System.Windows.Forms.TabPage p2;
        private System.Windows.Forms.Panel pnlPompier;
    }
}

