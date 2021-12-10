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
    public partial class ListCandidat : Form
    {
        const string SautDeLigne = "\r\n";

        public ListCandidat()
        {
            InitializeComponent();
        }

        private void ListCandidat_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=gcfainsta";
            var con = new MySqlConnection(cs);
            con.Open();

            var request = "SELECT LastName, FirstName, Age, Birthday, City, Postcode, Email, OvrAverage, PhoneNumber, Status FROM dbcandidat";
            var cmd = new MySqlCommand(request, con);

            var rdr = cmd.ExecuteReader();

            textBox1.Text = "";

            while (rdr.Read())
            {
                textBox1.Text += $"\a Nom:{rdr[0]} \a Prenom:{rdr[1]} \a Age:{rdr[2]} \a Birthday:{rdr[3]} \a City:{rdr[4]} Postcode:{rdr[5]} \a - Email:{rdr[6]} \a - OvrAverage:{rdr[7]} \a PhoneNumber:{rdr[8]} \a Status:{rdr[9]}{SautDeLigne}{SautDeLigne} ";
            }
            //textBox2.Text = $"Hello world 1{SautDeLigne}Hello world 2";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candidature candidature = new Candidature();
            candidature.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
