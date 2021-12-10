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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reise\OneDrive\Documents\GCFAINSTA.mdf;Integrated Security=True;Connect Timeout=30");

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            //condition if...else pour bloquer le bouton valider si les champs sont vides.
            if (TxtLogin.Text != "" && TxtPassword.Text != "")
            {
                Valider.Enabled = true;
            }
            else
            {
                Valider.Enabled = false;
            }
            //***************************************************************************//
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            //condition if...else pour bloquer le bouton valider si les champs sont vides.
            if (TxtLogin.Text != "" && TxtPassword.Text != "")
            {
                Valider.Enabled = true;
            }
            else
            {
                Valider.Enabled = false;
            }
            //***************************************************************************//
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string coserv = @"server=localhost;userid=root;password=;database=gcfainsta";
            var sqlConnexion = new MySqlConnection(coserv);
            if (TxtLogin.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Completez les informations svp");
            }
            else
            {
                try
                {
                    sqlConnexion.Open();
                    string req = "SELECT * FROM dbadmin WHERE Email ='" + TxtLogin.Text.Trim() +
                        "' AND Mdp = '" + TxtPassword.Text.Trim() + "'";
                    MySqlCommand cmd2 = new MySqlCommand(req, sqlConnexion);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Connexion avec succès");
                    GCFAINSTA gcfainsta = new GCFAINSTA();
                    gcfainsta.Show();
                    sqlConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (isValid())
            {
                using(MySqlConnection sqlConnection = new MySqlConnection(coserv))
                {
                    string query = "SELECT * FROM dbadmin WHERE Email ='"+ TxtLogin.Text.Trim() +
                        "' AND Mdp = '" + TxtPassword.Text.Trim() + "'";
                    //MySqlConnection sda = new MySqlConnection(query, sqlConnection);
                    DataTable dta = new DataTable();
                    //sda.Fill(dta);
                    if(dta.Rows.Count == 1)
                    {
                        sqlConnexion.Open();
                        MessageBox.Show("Connexion avec succès");
                        GCFAINSTA gcfainsta = new GCFAINSTA();
                        gcfainsta.Show();
                        sqlConnexion.Close();
                    }
                }
            }
        }

        private bool isValid()
        {
            if(TxtLogin.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Entrer un email valide", "Erreur");
                return false;
            }
            else if(TxtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Entrer un mot de passe valide", "Erreur");
                return false;
            }
            return true;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Candidature candidature = new Candidature();
            candidature.Show();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            int Année = Convert.ToUInt16(DateTime.Now.Year);
        }

        //----------------MDP CACHE--------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '*')
            {
                button1.BringToFront();
                TxtPassword.PasswordChar = '\0';
            }
            else if(TxtPassword.PasswordChar == '\0')
            {
                button1.BringToFront();
                TxtPassword.PasswordChar = '*';
            }
        }
        //--------------------------------------------------//
    }
}
