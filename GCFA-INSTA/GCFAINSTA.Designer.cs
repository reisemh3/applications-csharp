namespace GCFA_INSTA
{
    partial class GCFAINSTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCFAINSTA));
            this.CoAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.Average = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.TxtCodePostal = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.Label();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.ExitCandidat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoAdmin
            // 
            this.CoAdmin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CoAdmin.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoAdmin.Location = new System.Drawing.Point(99, 591);
            this.CoAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.CoAdmin.Name = "CoAdmin";
            this.CoAdmin.Size = new System.Drawing.Size(233, 62);
            this.CoAdmin.TabIndex = 0;
            this.CoAdmin.Text = "Connexion";
            this.CoAdmin.UseVisualStyleBackColor = false;
            this.CoAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(635, 591);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.Navy;
            this.Titre.Location = new System.Drawing.Point(465, 33);
            this.Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(417, 37);
            this.Titre.TabIndex = 9;
            this.Titre.Text = "Nouvelle candidature";
            // 
            // TxtNom
            // 
            this.TxtNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNom.Location = new System.Drawing.Point(217, 128);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(332, 22);
            this.TxtNom.TabIndex = 8;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.Transparent;
            this.Nom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Nom.ForeColor = System.Drawing.Color.Lavender;
            this.Nom.Location = new System.Drawing.Point(95, 132);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(59, 20);
            this.Nom.TabIndex = 7;
            this.Nom.Text = "Nom :";
            // 
            // TxtAge
            // 
            this.TxtAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAge.Location = new System.Drawing.Point(217, 220);
            this.TxtAge.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(332, 22);
            this.TxtAge.TabIndex = 11;
            this.TxtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Age.ForeColor = System.Drawing.Color.Lavender;
            this.Age.Location = new System.Drawing.Point(95, 224);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(59, 20);
            this.Age.TabIndex = 10;
            this.Age.Text = "Age :";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAdresse.Location = new System.Drawing.Point(217, 313);
            this.TxtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(332, 22);
            this.TxtAdresse.TabIndex = 13;
            this.TxtAdresse.TextChanged += new System.EventHandler(this.TxtAdresse_TextChanged);
            // 
            // Adresse
            // 
            this.Adresse.AutoEllipsis = true;
            this.Adresse.AutoSize = true;
            this.Adresse.BackColor = System.Drawing.Color.Transparent;
            this.Adresse.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Adresse.ForeColor = System.Drawing.Color.Lavender;
            this.Adresse.Location = new System.Drawing.Point(95, 316);
            this.Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(99, 20);
            this.Adresse.TabIndex = 12;
            this.Adresse.Text = "Adresse :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtEmail.Location = new System.Drawing.Point(217, 411);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(332, 22);
            this.TxtEmail.TabIndex = 15;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.Lavender;
            this.Email.Location = new System.Drawing.Point(95, 415);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(79, 20);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email :";
            // 
            // TxtAverage
            // 
            this.TxtAverage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAverage.Location = new System.Drawing.Point(473, 508);
            this.TxtAverage.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(76, 22);
            this.TxtAverage.TabIndex = 17;
            this.TxtAverage.TextChanged += new System.EventHandler(this.TxtAverage_TextChanged);
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.BackColor = System.Drawing.Color.Transparent;
            this.Average.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Average.ForeColor = System.Drawing.Color.Lavender;
            this.Average.Location = new System.Drawing.Point(95, 512);
            this.Average.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(349, 20);
            this.Average.TabIndex = 16;
            this.Average.Text = "Note générale du dernier diplôme :";
            // 
            // TxtNumber
            // 
            this.TxtNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNumber.Location = new System.Drawing.Point(952, 508);
            this.TxtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(235, 22);
            this.TxtNumber.TabIndex = 27;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Number.ForeColor = System.Drawing.Color.Lavender;
            this.Number.Location = new System.Drawing.Point(732, 512);
            this.Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(119, 20);
            this.Number.TabIndex = 26;
            this.Number.Text = "Téléphone :";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodePostal.Location = new System.Drawing.Point(952, 411);
            this.TxtCodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(235, 22);
            this.TxtCodePostal.TabIndex = 25;
            this.TxtCodePostal.TextChanged += new System.EventHandler(this.TxtCodePostal_TextChanged);
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.BackColor = System.Drawing.Color.Transparent;
            this.CodePostal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.CodePostal.ForeColor = System.Drawing.Color.Lavender;
            this.CodePostal.Location = new System.Drawing.Point(732, 415);
            this.CodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(139, 20);
            this.CodePostal.TabIndex = 24;
            this.CodePostal.Text = "Code Postal :";
            // 
            // TxtVille
            // 
            this.TxtVille.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtVille.Location = new System.Drawing.Point(855, 313);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(332, 22);
            this.TxtVille.TabIndex = 23;
            this.TxtVille.TextChanged += new System.EventHandler(this.TxtVille_TextChanged);
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.BackColor = System.Drawing.Color.Transparent;
            this.Ville.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ville.ForeColor = System.Drawing.Color.Lavender;
            this.Ville.Location = new System.Drawing.Point(732, 316);
            this.Ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(79, 20);
            this.Ville.TabIndex = 22;
            this.Ville.Text = "Ville :";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPrenom.Location = new System.Drawing.Point(855, 128);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(332, 22);
            this.TxtPrenom.TabIndex = 19;
            this.TxtPrenom.TextChanged += new System.EventHandler(this.TxtPrenom_TextChanged);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.BackColor = System.Drawing.Color.Transparent;
            this.Prenom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.Prenom.ForeColor = System.Drawing.Color.Lavender;
            this.Prenom.Location = new System.Drawing.Point(732, 132);
            this.Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(89, 20);
            this.Prenom.TabIndex = 18;
            this.Prenom.Text = "Prenom :";
            // 
            // ExitCandidat
            // 
            this.ExitCandidat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitCandidat.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCandidat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitCandidat.Location = new System.Drawing.Point(955, 591);
            this.ExitCandidat.Margin = new System.Windows.Forms.Padding(4);
            this.ExitCandidat.Name = "ExitCandidat";
            this.ExitCandidat.Size = new System.Drawing.Size(233, 62);
            this.ExitCandidat.TabIndex = 28;
            this.ExitCandidat.Text = "Annuler";
            this.ExitCandidat.UseVisualStyleBackColor = false;
            this.ExitCandidat.Click += new System.EventHandler(this.ExitCandidat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // GCFAINSTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitCandidat);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.TxtCodePostal);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.TxtVille);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TxtAdresse);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CoAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GCFAINSTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCFA INSTA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CoAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox TxtCodePostal;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Button ExitCandidat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

