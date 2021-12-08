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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load_1(object sender, EventArgs e)
        {
            int Année = Convert.ToUInt16(DateTime.Now.Year);
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtLogin.Text != "" && TxtPassword.Text != "")
            {
                Valider.Enabled = true;
            }
            else
            {
                Valider.Enabled = false;
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {

            ListCandidat valider = new ListCandidat();
            valider.Show();
            //this.Close();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            GCFAINSTA valider = new GCFAINSTA();
            valider.Show();
            //this.Close();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        //----------------------Color Section Label-----------------------//
        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            TxtLogin.BackColor = Color.MediumTurquoise;
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            TxtLogin.BackColor = Color.White;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.BackColor = Color.MediumTurquoise;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            TxtPassword.BackColor = Color.White;
        }
        //-------------------------------------------------------------------//
    }
}
