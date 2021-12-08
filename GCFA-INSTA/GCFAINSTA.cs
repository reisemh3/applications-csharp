using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCFA_INSTA
{
    public partial class GCFAINSTA : Form
    {
        public GCFAINSTA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion valider = new Connexion();
            valider.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListCandidat valider = new ListCandidat();
            valider.Show();
            //this.Close();
        }

        private void ExitCandidat_Click(object sender, EventArgs e)
        {

        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodePostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAverage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
