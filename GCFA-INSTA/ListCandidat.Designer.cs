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
            this.TitreList.Size = new System.Drawing.Size(329, 33);
            this.TitreList.TabIndex = 10;
            this.TitreList.Text = "Liste des candidatures";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(960, 384);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListCandidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Candidats";
            this.Load += new System.EventHandler(this.ListCandidat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMenu;
        private System.Windows.Forms.Label TitreList;
        private System.Windows.Forms.TextBox textBox1;
    }
}