namespace ucNavSae24
{
partial class ucNav
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

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnVe = new System.Windows.Forms.Button();
            this.btnSt = new System.Windows.Forms.Button();
            this.btnNm = new System.Windows.Forms.Button();
            this.btnGp = new System.Windows.Forms.Button();
            this.btnTb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVe
            // 
            this.btnVe.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.fire_engine;
            this.btnVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVe.Location = new System.Drawing.Point(140, 10);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(40, 40);
            this.btnVe.TabIndex = 6;
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click_1);
            // 
            // btnSt
            // 
            this.btnSt.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.statistics;
            this.btnSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSt.Location = new System.Drawing.Point(260, 10);
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(40, 40);
            this.btnSt.TabIndex = 3;
            this.btnSt.UseVisualStyleBackColor = true;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // btnNm
            // 
            this.btnNm.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.goal_achievement_mission_business_success_finish_flag_target_icon_232591;
            this.btnNm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNm.Location = new System.Drawing.Point(80, 10);
            this.btnNm.Name = "btnNm";
            this.btnNm.Size = new System.Drawing.Size(40, 40);
            this.btnNm.TabIndex = 2;
            this.btnNm.UseVisualStyleBackColor = true;
            this.btnNm.Click += new System.EventHandler(this.btnNm_Click);
            // 
            // btnGp
            // 
            this.btnGp.BackgroundImage = global::frmSinistreSAE24.Properties.Resources.firefighter_helmet;
            this.btnGp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGp.Location = new System.Drawing.Point(200, 10);
            this.btnGp.Name = "btnGp";
            this.btnGp.Size = new System.Drawing.Size(40, 40);
            this.btnGp.TabIndex = 1;
            this.btnGp.UseVisualStyleBackColor = true;
            this.btnGp.Click += new System.EventHandler(this.btnGp_Click);
            // 
            // btnTb
            // 
            this.btnTb.BackgroundImage = global::frmSinistreSAE24.Properties.Resources._9055226_bxs_dashboard_icon;
            this.btnTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTb.Location = new System.Drawing.Point(20, 10);
            this.btnTb.Name = "btnTb";
            this.btnTb.Size = new System.Drawing.Size(40, 40);
            this.btnTb.TabIndex = 0;
            this.btnTb.UseVisualStyleBackColor = true;
            this.btnTb.Click += new System.EventHandler(this.btnTb_Click);
            // 
            // ucNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.btnSt);
            this.Controls.Add(this.btnNm);
            this.Controls.Add(this.btnGp);
            this.Controls.Add(this.btnTb);
            this.Name = "ucNav";
            this.Size = new System.Drawing.Size(320, 60);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnTb;
    private System.Windows.Forms.Button btnGp;
    private System.Windows.Forms.Button btnNm;
    private System.Windows.Forms.Button btnSt;
    private System.Windows.Forms.Button btnVe;
    }
}
