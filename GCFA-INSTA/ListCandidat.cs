﻿using System;
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
    public partial class ListCandidat : Form
    {
        public ListCandidat()
        {
            InitializeComponent();
        }

        private void ListCandidat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GCFAINSTA valider = new GCFAINSTA();
            valider.Show();
            //this.Close();
        }
    }
}
