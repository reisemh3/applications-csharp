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
    public partial class GCFAINSTA : Form
    {
        public GCFAINSTA()
        {
            InitializeComponent();
        }
        private void Reinitialiser()
        {
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtAge.Text = "";
            DateTimePicker.Text = "";
            TxtAdresse.Text = "";
            TxtVille.Text = "";
            TxtEmail.Text = "";
            TxtCodePostal.Text = "";
            TxtAverage.Text = "";
            TxtNumber.Text = "";
            //Cle = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Close();
        }

        //-------------------------Bouton Valider--------------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text == "" || TxtPrenom.Text == "" || TxtAge.Text == "" ||
                DateTimePicker.Text == "" || TxtAdresse.Text == "" || TxtVille.Text == "" ||
                TxtEmail.Text == "" || TxtCodePostal.Text == "" || TxtAverage.Text == "" ||
                TxtNumber.Text == "")
            {
                MessageBox.Show("Completez les informations svp");
            }
            else
            {
                try
                {
                    string coserv = @"server=localhost;userid=root;password=;database=gcfainsta";
                    //var sqlConnexion = new SqlConnection(coserv);

                    //sqlConnexion.Open();
                    var req = "insert into Candidats values('" + TxtNom.Text + "', '" + TxtPrenom.Text + "','" + TxtAge.Text + "','" + DateTimePicker.Text + "','" + TxtAdresse.Text + "','" + TxtVille.Text + "','" + TxtEmail.Text + "','" + TxtCodePostal.Text + "','" + TxtAverage.Text + "','" + TxtNumber.Text + "')";
                    //var cmd = new MySqlCommand(req, sqlConnexion);
                    //var cmd = ExecuteReader();
                    MessageBox.Show("Candidat ajouté avec succès");
                    //sqlConnexion.Close();
                    Reinitialiser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            //ListCandidat listCandidat = new ListCandidat();
            //listCandidat.Show();
            //this.Close();
            //***************************************************************************//
        }
        //-------------------------Bouton Annuler--------------------------//
        private void ExitCandidat_Click(object sender, EventArgs e)
        {
            //Reinitialiser();
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            //Candidature candidature = new Candidature();
            //candidature.Show();
            //this.Close();
            ListCandidat listCandidat = new ListCandidat();
            listCandidat.Show();
            this.Close();
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

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
