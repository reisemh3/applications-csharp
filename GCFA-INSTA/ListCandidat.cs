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
    public partial class ListCandidat : Form
    {
        public ListCandidat()
        {
            InitializeComponent();
        }
        //------------------Fenetre princîpal de ListCandidat-----------------//
        private void ListCandidat_Load(object sender, EventArgs e)
        {

        }
        //-------------------------Bouton Retour------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Candidature candidature = new Candidature();
            candidature.Show();
            //this.Close();
            //***************************************************************************//
        }
        //---------------------Fenetre d'affichage List------------------------//
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
