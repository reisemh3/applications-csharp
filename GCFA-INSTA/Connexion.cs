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
        //------------------Fenetre princîpal de Connexion-----------------//
        private void Connexion_Load_1(object sender, EventArgs e)
        {
            int Année = Convert.ToUInt16(DateTime.Now.Year);
        }
        //----------------------Champs Text ID-----------------------------//
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
        //----------------------Change Text mot de passe--------------------//
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
        //-------------------------Bouton Valider--------------------------//
        private void Valider_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            Candidature candidature = new Candidature();
            candidature.Show();
            this.Hide();
            //***************************************************************************//
        }
        //-------------------------Bouton Annuler--------------------------//
        private void Annuler_Click(object sender, EventArgs e)
        {
            //Création d'une fonction qui ouvre une nouvlle fenetre en cliquant sur le bouton
            GCFAINSTA gcfainsta = new GCFAINSTA();              
            gcfainsta.Show();
            this.Hide();
            //***************************************************************************//
        }
        //--------------Fenetre Connexion à ne pas toucher-----------------//
        private void Connexion_Load(object sender, EventArgs e)
        {

        }
        //----------------------Color Section Label-----------------------//
        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            //Focus sur un champs selectionné
            TxtLogin.BackColor = Color.MediumTurquoise;
            //***************************************************************************//
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            //Focus annulé si le champs quitté
            TxtLogin.BackColor = Color.White;
            //***************************************************************************//
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            //Focus sur un champs selectionné
            TxtPassword.BackColor = Color.MediumTurquoise;
            //***************************************************************************//

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            //Focus annulé si le champs quitté
            TxtPassword.BackColor = Color.White;
            //***************************************************************************//
        }
        //-------------------------------------------------------------------//
    }
}
