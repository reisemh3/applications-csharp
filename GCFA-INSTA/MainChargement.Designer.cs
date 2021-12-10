namespace GCFA_INSTA
{
    partial class MainChargement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChargement));
            this.BarProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PourcentageLabel = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BarProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarProgress
            // 
            this.BarProgress.BackColor = System.Drawing.Color.Transparent;
            this.BarProgress.Controls.Add(this.PourcentageLabel);
            this.BarProgress.FillColor = System.Drawing.SystemColors.Highlight;
            this.BarProgress.FillOffset = 20;
            this.BarProgress.FillThickness = 10;
            this.BarProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BarProgress.ForeColor = System.Drawing.Color.White;
            this.BarProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.BarProgress.InnerColor = System.Drawing.Color.Transparent;
            this.BarProgress.Location = new System.Drawing.Point(275, 75);
            this.BarProgress.Minimum = 0;
            this.BarProgress.Name = "BarProgress";
            this.BarProgress.ProgressColor = System.Drawing.Color.White;
            this.BarProgress.ProgressColor2 = System.Drawing.Color.White;
            this.BarProgress.ProgressOffset = 20;
            this.BarProgress.ProgressThickness = 10;
            this.BarProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BarProgress.ShadowDecoration.Parent = this.BarProgress;
            this.BarProgress.Size = new System.Drawing.Size(164, 164);
            this.BarProgress.TabIndex = 0;
            this.BarProgress.Text = "BarProgress";
            // 
            // PourcentageLabel
            // 
            this.PourcentageLabel.AutoSize = true;
            this.PourcentageLabel.BackColor = System.Drawing.Color.Transparent;
            this.PourcentageLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.PourcentageLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.PourcentageLabel.Location = new System.Drawing.Point(51, 65);
            this.PourcentageLabel.Name = "PourcentageLabel";
            this.PourcentageLabel.Size = new System.Drawing.Size(37, 33);
            this.PourcentageLabel.TabIndex = 8;
            this.PourcentageLabel.Text = "%";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titre.ForeColor = System.Drawing.Color.Navy;
            this.Titre.Location = new System.Drawing.Point(265, 25);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(179, 33);
            this.Titre.TabIndex = 7;
            this.Titre.Text = "GCFA INSTA";
            this.Titre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(245, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veuillez patienter quelques instants";
            // 
            // MainChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.BarProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainChargement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.MainChargement_Load);
            this.BarProgress.ResumeLayout(false);
            this.BarProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar BarProgress;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PourcentageLabel;
        private System.Windows.Forms.Label label1;
    }
}