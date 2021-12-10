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

            string cs = @"server=localhost;userid=root;password=;database=gcfainsta";
            var sqlConnexion = new MySqlConnection(cs);
            sqlConnexion.Open();
            Console.WriteLine($"MySQL version : {sqlConnexion.ServerVersion}");
            var stm = "SELECT IdAdmin, Email, Mdp, Num FROM dbadmin";
            var cmd = new MySqlCommand(stm, sqlConnexion);
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(rdr[i]);
                i++;
            }
        }

        //SqlConnection sqlConnexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reise\OneDrive\Documents\GCFAINSTA.mdf;Integrated Security=True;Connect Timeout=30");

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            string coserv = @"server=localhost;userid=root;password=;database=gcfainsta";
            var sqlConnexion = new MySqlConnection(coserv);
            sqlConnexion.Open();
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
            string coserv = @"server=localhost;userid=root;password=;database=gcfainsta";
            var sqlConnexion = new MySqlConnection(coserv);
            sqlConnexion.Open();
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
                sqlConnexion.Open();
                Console.WriteLine($"MySQL version : {sqlConnexion.ServerVersion}");
                var stm = "SELECT IdAdmin, Email, Mdp, Num FROM dbadmin";
                var cmd = new MySqlCommand(stm, sqlConnexion);
                var rdr = cmd.ExecuteReader();
                rdr.Read();
                int i = 0;
                while (i < 4)
                {
                    Console.WriteLine(rdr[i]);
                    i++;
                }

                var sda = new MySqlDataAdapter("select count(*) from dbadmin where Email='" + TxtLogin + "' and Mdp='" + TxtPassword + "'", coserv);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ListCandidat listCandidat = new ListCandidat();
                    listCandidat.Show();
                    this.Hide();
                    sqlConnexion.Close();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
                sqlConnexion.Close();
            }

            if (TxtLogin.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Completez les informations svp");
            }
            else
            {
                try
                {
                    sqlConnexion.Open();
                    string req = "insert into Candidats values('" + TxtLogin.Text + "', '" + TxtPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(req);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connexion avec succès");
                    sqlConnexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
                //ListCandidat listCandidat = new ListCandidat();
                //listCandidat.Show();
                this.Close();
                //***************************************************************************//
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            GCFAINSTA valider = new GCFAINSTA();
            valider.Show();
            //this.Close();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            int Année = Convert.ToUInt16(DateTime.Now.Year);
        }
    }
}
