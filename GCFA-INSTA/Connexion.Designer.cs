namespace GCFA_INSTA
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.Valider = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Valider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Valider.Location = new System.Drawing.Point(126, 179);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(175, 50);
            this.Valider.TabIndex = 0;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Annuler.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Annuler.Location = new System.Drawing.Point(370, 179);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(175, 50);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.Lavender;
            this.ID.Location = new System.Drawing.Point(221, 76);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(33, 17);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID :";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.BackColor = System.Drawing.Color.Transparent;
            this.mdp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.mdp.ForeColor = System.Drawing.Color.Lavender;
            this.mdp.Location = new System.Drawing.Point(141, 131);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(116, 17);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "Mot de passe :";
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtLogin.ForeColor = System.Drawing.Color.Navy;
            this.TxtLogin.Location = new System.Drawing.Point(286, 74);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(250, 21);
            this.TxtLogin.TabIndex = 4;
            this.TxtLogin.TextChanged += new System.EventHandler(this.TxtLogin_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtPassword.ForeColor = System.Drawing.Color.Navy;
            this.TxtPassword.Location = new System.Drawing.Point(286, 127);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(250, 21);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titre.ForeColor = System.Drawing.Color.Navy;
            this.Titre.Location = new System.Drawing.Point(138, 21);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(434, 33);
            this.Titre.TabIndex = 6;
            this.Titre.Text = "Veuillez entrer vos identifiants";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label Titre;
    }
}