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
        //---------------------Fenetre princîpal de GCFAINSTA-----------------------//
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //-------------------------Bouton Connexion--------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Connexion connexion = new Connexion();
            connexion.Show();
            //this.Close();
            //***************************************************************************//
        }
        //-------------------------Bouton Valider--------------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            ListCandidat listCandidat = new ListCandidat();
            listCandidat.Show();
            //this.Close();
            //***************************************************************************//
        }
        //-------------------------Bouton Annuler--------------------------//
        private void ExitCandidat_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Candidature candidature = new Candidature();
            candidature.Show();
            //this.Close();
            //***************************************************************************//
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
