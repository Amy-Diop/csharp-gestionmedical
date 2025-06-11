using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    // Faire la gestion des erreurs
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
        //BdRvMedicalContext db= new BdRvMedicalContext();

        ServicePatient.IPatientClient service = new ServicePatient.IPatientClient();


        private void ResetForm()
        {
            txtNomPrenom.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtDateNaissance.Value = DateTime.Now;
            txtGroupeSanguin.Text = string.Empty;
            txtPoids.Text = string.Empty;
            txtTaille.Text = string.Empty;
            dgPatient.DataSource = service.GetListePatients();
            txtNomPrenom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ServicePatient.Patient p = new ServicePatient.Patient();
            p.NomPrenom=txtNomPrenom.Text;
            p.Adresse=txtAdresse.Text;
            p.Tel=txtTel.Text;
            p.Email=txtEmail.Text;
            p.DateNaissance = DateTime.Parse(txtDateNaissance.Text);
            p.Poids=float.Parse(txtPoids.Text);
            p.Taille=float.Parse(txtTaille.Text);
            p.GroupeSanguin=txtGroupeSanguin.Text;
            //db.Patients.Add(p);
            //db.SaveChanges();
            service.AddPatient(p);
            ResetForm();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txtTel.Text = dgPatient.CurrentRow.Cells[8].Value.ToString();
            txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            txtDateNaissance.Value = DateTime.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnModidier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            if (id != 0)
            {

                var p = service.GetPatientById(id);
                p.NomPrenom = txtNomPrenom.Text;
                p.Adresse = txtAdresse.Text;
                p.Tel = txtTel.Text;
                p.Email = txtEmail.Text;
                p.DateNaissance = DateTime.Parse(txtDateNaissance.Text);
                p.Poids = float.Parse(txtPoids.Text);
                p.Taille = float.Parse(txtTaille.Text);
                p.GroupeSanguin = txtGroupeSanguin.Text;
                //db.SaveChanges();
                service.AddPatient(p);
                ResetForm();

            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgPatient.CurrentRow.Cells[4].Value.ToString());
            service.SupprimerPatient(id);
            ResetForm();
        }


        private void btnRendezVous_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string email = txtREmail.Text.Trim();
            string tel = txtRTelephone.Text.Trim();
            var result = service.GetListePatients().ToList();
            dgPatient.DataSource = result;
        }


        private void txtRtelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRendezVous_Click_1(object sender, EventArgs e)
        {
            frmRendezVous f = new frmRendezVous();
            f.Show();
            this.Hide();
            this.Enabled = false;
        }
    }
}
