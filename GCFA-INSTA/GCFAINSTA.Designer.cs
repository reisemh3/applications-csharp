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
            this.Birthday = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.ExitCandidat = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(616, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titre.ForeColor = System.Drawing.Color.Navy;
            this.Titre.Location = new System.Drawing.Point(349, 27);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(297, 32);
            this.Titre.TabIndex = 9;
            this.Titre.Text = "Nouvelle candidature";
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNom.Location = new System.Drawing.Point(214, 104);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(250, 21);
            this.TxtNom.TabIndex = 8;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.Transparent;
            this.Nom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Nom.ForeColor = System.Drawing.Color.Lavender;
            this.Nom.Location = new System.Drawing.Point(122, 107);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(45, 16);
            this.Nom.TabIndex = 7;
            this.Nom.Text = "Nom :";
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAge.Location = new System.Drawing.Point(214, 179);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(250, 21);
            this.TxtAge.TabIndex = 11;
            this.TxtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Age.ForeColor = System.Drawing.Color.Lavender;
            this.Age.Location = new System.Drawing.Point(122, 182);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 16);
            this.Age.TabIndex = 10;
            this.Age.Text = "Age :";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtAdresse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAdresse.Location = new System.Drawing.Point(214, 254);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(250, 21);
            this.TxtAdresse.TabIndex = 13;
            this.TxtAdresse.TextChanged += new System.EventHandler(this.TxtAdresse_TextChanged);
            // 
            // Adresse
            // 
            this.Adresse.AutoEllipsis = true;
            this.Adresse.AutoSize = true;
            this.Adresse.BackColor = System.Drawing.Color.Transparent;
            this.Adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Adresse.ForeColor = System.Drawing.Color.Lavender;
            this.Adresse.Location = new System.Drawing.Point(122, 257);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(67, 16);
            this.Adresse.TabIndex = 12;
            this.Adresse.Text = "Adresse :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtEmail.Location = new System.Drawing.Point(214, 334);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(250, 21);
            this.TxtEmail.TabIndex = 15;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.Color.Lavender;
            this.Email.Location = new System.Drawing.Point(122, 337);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(51, 16);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email :";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtAverage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAverage.Location = new System.Drawing.Point(406, 413);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(58, 21);
            this.TxtAverage.TabIndex = 17;
            this.TxtAverage.TextChanged += new System.EventHandler(this.TxtAverage_TextChanged);
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.BackColor = System.Drawing.Color.Transparent;
            this.Average.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Average.ForeColor = System.Drawing.Color.Lavender;
            this.Average.Location = new System.Drawing.Point(122, 416);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(238, 16);
            this.Average.TabIndex = 16;
            this.Average.Text = "Note générale du dernier diplôme :";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNumber.Location = new System.Drawing.Point(675, 413);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(177, 21);
            this.TxtNumber.TabIndex = 27;
            this.TxtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Number.ForeColor = System.Drawing.Color.Lavender;
            this.Number.Location = new System.Drawing.Point(510, 416);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(82, 16);
            this.Number.TabIndex = 26;
            this.Number.Text = "Téléphone :";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtCodePostal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodePostal.Location = new System.Drawing.Point(675, 334);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(177, 21);
            this.TxtCodePostal.TabIndex = 25;
            this.TxtCodePostal.TextChanged += new System.EventHandler(this.TxtCodePostal_TextChanged);
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.BackColor = System.Drawing.Color.Transparent;
            this.CodePostal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CodePostal.ForeColor = System.Drawing.Color.Lavender;
            this.CodePostal.Location = new System.Drawing.Point(510, 337);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(92, 16);
            this.CodePostal.TabIndex = 24;
            this.CodePostal.Text = "Code Postal :";
            // 
            // TxtVille
            // 
            this.TxtVille.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtVille.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtVille.Location = new System.Drawing.Point(602, 254);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(250, 21);
            this.TxtVille.TabIndex = 23;
            this.TxtVille.TextChanged += new System.EventHandler(this.TxtVille_TextChanged);
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.BackColor = System.Drawing.Color.Transparent;
            this.Ville.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ville.ForeColor = System.Drawing.Color.Lavender;
            this.Ville.Location = new System.Drawing.Point(510, 257);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(44, 16);
            this.Ville.TabIndex = 22;
            this.Ville.Text = "Ville :";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.BackColor = System.Drawing.Color.Transparent;
            this.Birthday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Birthday.ForeColor = System.Drawing.Color.Lavender;
            this.Birthday.Location = new System.Drawing.Point(510, 182);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(136, 16);
            this.Birthday.TabIndex = 20;
            this.Birthday.Text = "Date de naissance :";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtPrenom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPrenom.Location = new System.Drawing.Point(602, 104);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(250, 21);
            this.TxtPrenom.TabIndex = 19;
            this.TxtPrenom.TextChanged += new System.EventHandler(this.TxtPrenom_TextChanged);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.BackColor = System.Drawing.Color.Transparent;
            this.Prenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Prenom.ForeColor = System.Drawing.Color.Lavender;
            this.Prenom.Location = new System.Drawing.Point(510, 107);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(63, 16);
            this.Prenom.TabIndex = 18;
            this.Prenom.Text = "Prenom :";
            // 
            // ExitCandidat
            // 
            this.ExitCandidat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitCandidat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.ExitCandidat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitCandidat.Location = new System.Drawing.Point(797, 499);
            this.ExitCandidat.Name = "ExitCandidat";
            this.ExitCandidat.Size = new System.Drawing.Size(175, 50);
            this.ExitCandidat.TabIndex = 28;
            this.ExitCandidat.Text = "Annuler";
            this.ExitCandidat.UseVisualStyleBackColor = false;
            this.ExitCandidat.Click += new System.EventHandler(this.ExitCandidat_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.DateTimePicker.Location = new System.Drawing.Point(675, 179);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(177, 21);
            this.DateTimePicker.TabIndex = 29;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(122, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Candidature validé ou refusé :";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.FlatAppearance.BorderSize = 5;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(406, 472);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(13, 12);
            this.checkBox.TabIndex = 32;
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // GCFAINSTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ExitCandidat);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.TxtCodePostal);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.TxtVille);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.Birthday);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Button ExitCandidat;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

