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
    public partial class Candidature : Form
    {
        public Candidature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GCFAINSTA valider = new GCFAINSTA();
            valider.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListCandidat valider = new ListCandidat();
            valider.Show();
            //this.Close();
        }
    }
}
