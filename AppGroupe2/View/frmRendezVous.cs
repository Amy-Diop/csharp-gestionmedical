﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGroupe2.View
{
    public partial class frmRendezVous : Form
    {
        public frmRendezVous()
        {
            InitializeComponent();
        }

        private void frmRendezVous_Load(object sender, EventArgs e)
        {

        }

        private void frmRendezVous_Leave(object sender, EventArgs e)
        {
            frmPatient f = new frmPatient();
            f.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPatient f = new frmPatient();
            f.Enabled = true;
            this.Close();
           // f.Show(); // Ouvre la fenêtre normalement
            //this.Close(); // Ferme la fenêtre actuelle (facultatif)
            //f.Enabled = true;

        }
    }
}
