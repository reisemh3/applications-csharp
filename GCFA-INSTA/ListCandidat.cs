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



namespace GCFA_INSTA
{
    public partial class ListCandidat : Form
    {
        internal static ApplicationsDataContext ApplicationsDB = new ApplicationsDataContext();
        public object DataSource { get; set; }
        private DataGridView dataGridView1 = new DataGridView();

        public ListCandidat()
        {
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
            InitializeComponent();
        }
      
        //------------------Fenetre princîpal de ListCandidat-----------------//
        private void ListCandidat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListCandidat.ApplicationsDB.Applicant;
        }
        //-------------------------Bouton Retour------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Candidature candidature = new Candidature();
            candidature.Show();
            this.Hide();
            //***************************************************************************//
        }
        //---------------------Fenetre d'affichage List------------------------//
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
