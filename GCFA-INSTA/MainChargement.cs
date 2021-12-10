using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GCFA_INSTA
{
    public partial class MainChargement : Form
    {
        public MainChargement()
        {
            InitializeComponent();
        }
        private void MainChargement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Titre_Click(object sender, EventArgs e)
        {

        }
        int pdd = 0;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            pdd += 1;
            BarProgress.Value = pdd;
            PourcentageLabel.Text = pdd + "%";
            if (BarProgress.Value == 100)
            {
                BarProgress.Value = 0;
                timer1.Stop();
                Candidature candidature = new Candidature();
                candidature.Show();
                this.Hide();
                //await Task.Delay(5000);
                //this.Close();
            }
        }
    }
}