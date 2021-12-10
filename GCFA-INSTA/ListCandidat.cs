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

            var request = "SELECT LastName, FirstName, Age, Birthday, Adress, City, Postcode, Email, OvrAverage, PhoneNumber FROM dbcandidat";
            var cmd = new MySqlCommand(request, con);
            
            //dataGridView1.Text += $"DataGridViewCellStyle {rdr[0]}";

            var rdr = cmd.ExecuteReader();

            textBox1.Text = "";
            //dataGridView1.Text = "";
            //int[,] azeaz = new int[];
            //int[] lister;
            //lister = new int[] { { rdr[0] },{ rdr[1] },{ rdr[2] },{ rdr[3] },{ rdr[4] },{ rdr[5] },{ rdr[6] },{ rdr[7] },{ rdr[8] },{ rdr[9] } };
            //int[] t = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
             //   t[i] = Convert.ToInt32(textBox1.Text());
            //}
            //for (int i = 0; i < 10; i++)
            //{
             //   textBox1.Text(t[i] + " | ");
            //}

            while (rdr.Read())
            {
                //int[,] textBox1 = { { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
                textBox1.Text += $"||--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------||" +
                    $"{SautDeLigne}" +
                    $"\t\a {rdr[0]} \a {rdr[1]}  \a   {rdr[2]}   \t\t\a     {rdr[3]}     \a     {rdr[4]}    \t\a  {rdr[5]}  \t\a      {rdr[6]}   \t\a     {rdr[7]}    \t\a  {rdr[8]}    \a   {rdr[9]}   \a {SautDeLigne}{SautDeLigne} ";
                
                
                
                //dataGridView1.Text += $"\a Nom:{rdr[0]} \a Prenom:{rdr[1]} \a Age:{rdr[2]} \a Birthday:{rdr[3]} \a Adress:{rdr[4]} \a Ville:{rdr[5]} Postcode:{rdr[6]} \a - Email:{rdr[7]} \a - OvrAverage:{rdr[8]} \a Tel:{rdr[9]} \a {SautDeLigne}{SautDeLigne} ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
