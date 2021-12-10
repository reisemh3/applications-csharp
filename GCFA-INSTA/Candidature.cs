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
    public partial class Candidature : Form
    {
        public Candidature()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            await Task.Delay(3000);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListCandidat listCandidat = new ListCandidat();
            listCandidat.Show();
            this.Close();
        }
    }
}
