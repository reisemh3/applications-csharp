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
        //-------------------------Bouton Candidature---------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            GCFAINSTA gcfainsta = new GCFAINSTA();
            gcfainsta.Show();
            //this.Close();
            //***************************************************************************//
        }
        //-------------------------Bouton ListCandidat-------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            ListCandidat listCandidat = new ListCandidat();
            listCandidat.Show();
            //this.Close();
            //***************************************************************************//
        }
    }
}
