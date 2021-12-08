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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            ListCandidat valider = new ListCandidat();
            valider.Show();
            //this.Close();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            GCFAINSTA valider = new GCFAINSTA();
            valider.Show();
            //this.Close();
        }
    }
}
