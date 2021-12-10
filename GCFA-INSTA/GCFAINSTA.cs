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
            try
            {
                //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
                ListCandidat listCandidat = new ListCandidat();
                Applicant app1 = new Applicant();
                app1.lastName = TxtNom.Text;
                app1.firstName = TxtPrenom.Text;
                app1.age = int.Parse(TxtAge.Text);
                app1.address = TxtAdresse.Text;
                app1.city = TxtVille.Text;
                app1.postcode = int.Parse(TxtCodePostal.Text);
                app1.mail = TxtEmail.Text;
                app1.ovrAverage = float.Parse(TxtAverage.Text);
                app1.phoneNumber = int.Parse(TxtNumber.Text);

                ListCandidat.ApplicationsDB.Applicant.InsertOnSubmit(app1);
                ListCandidat.ApplicationsDB.SubmitChanges();
                Console.WriteLine(app1);
                MessageBox.Show("Le candidat a été ajouté.");
                listCandidat.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + "Veuillez remplir tous les champs avant de valider la candidature.");
            }
            //***************************************************************************//
        }
        //-------------------------Bouton Annuler--------------------------//
        private void ExitCandidat_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Candidature candidature = new Candidature();
            candidature.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
