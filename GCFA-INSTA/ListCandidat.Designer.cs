namespace GCFA_INSTA
{
    partial class ListCandidat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCandidat));
            this.ReturnMenu = new System.Windows.Forms.Button();
            this.TitreList = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReturnMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ReturnMenu.ForeColor = System.Drawing.Color.GhostWhite;
            this.ReturnMenu.Location = new System.Drawing.Point(797, 499);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(175, 50);
            this.ReturnMenu.TabIndex = 0;
            this.ReturnMenu.Text = "Retour";
            this.ReturnMenu.UseVisualStyleBackColor = false;
            this.ReturnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitreList
            // 
            this.TitreList.AutoSize = true;
            this.TitreList.BackColor = System.Drawing.Color.Transparent;
            this.TitreList.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.TitreList.ForeColor = System.Drawing.Color.Navy;
            this.TitreList.Location = new System.Drawing.Point(317, 32);
            this.TitreList.Name = "TitreList";
            this.TitreList.Size = new System.Drawing.Size(305, 32);
            this.TitreList.TabIndex = 10;
            this.TitreList.Text = "Liste des candidatures";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(960, 375);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.Age,
            this.Birthday,
            this.Adresse,
            this.Ville,
            this.CodePostal,
            this.Email,
            this.Moyenne,
            this.Telephone,
            this.Statut});
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 62);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nom.Width = 75;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.Width = 75;
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "CodePostal";
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Width = 75;
            // 
            // Email
            // 
            this.Email.FillWeight = 75F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Moyenne
            // 
            this.Moyenne.HeaderText = "Moyenne";
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Width = 75;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            this.Statut.Width = 75;
            // 
            // ListCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TitreList);
            this.Controls.Add(this.ReturnMenu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListCandidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Candidats";
            this.Load += new System.EventHandler(this.ListCandidat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMenu;
        private System.Windows.Forms.Label TitreList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
    }
}