namespace sae24_gestion_des_pompiers
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_se_connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(65, 49);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 0;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(65, 75);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = 'A';
            this.txt_mdp.Size = new System.Drawing.Size(100, 20);
            this.txt_mdp.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(24, 52);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(36, 13);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login:";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(24, 78);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(34, 13);
            this.lbl_mdp.TabIndex = 3;
            this.lbl_mdp.Text = "MDP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Connectez-vous:";
            // 
            // btn_se_connecter
            // 
            this.btn_se_connecter.Location = new System.Drawing.Point(32, 153);
            this.btn_se_connecter.Name = "btn_se_connecter";
            this.btn_se_connecter.Size = new System.Drawing.Size(133, 23);
            this.btn_se_connecter.TabIndex = 5;
            this.btn_se_connecter.Text = "Se connecter.";
            this.btn_se_connecter.UseVisualStyleBackColor = true;
            this.btn_se_connecter.Click += new System.EventHandler(this.btn_se_connecter_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 209);
            this.Controls.Add(this.btn_se_connecter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_se_connecter;
    }
}