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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReturnMenu.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TitreList.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreList.ForeColor = System.Drawing.Color.Navy;
            this.TitreList.Location = new System.Drawing.Point(317, 32);
            this.TitreList.Name = "TitreList";
            this.TitreList.Size = new System.Drawing.Size(366, 31);
            this.TitreList.TabIndex = 10;
            this.TitreList.Text = "Liste des candidatures";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(960, 395);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ListCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TitreList);
            this.Controls.Add(this.ReturnMenu);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}