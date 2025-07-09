using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    public partial class frmRendezVous : Form
    {
        private List<RendezVous> rendezVousList = new List<RendezVous>();

        public frmRendezVous()
        {
            InitializeComponent();
        }

        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            ResetForm();
        }

        private void LoadComboBoxes()
        {
            // Exemple statique pour remplir les ComboBox
            cbMedecin.DataSource = new List<string> { "Dr Fall", "Dr Ndiaye", "Dr Sow" };
            cbPatient.DataSource = new List<string> { "Patient A", "Patient B", "Patient C" };
            cbSoin.DataSource = new List<string> { "Consultation", "Vaccination", "Suivi" };
        }

        private void ResetForm()
        {
            dtpDateRv.Value = DateTime.Now;
            txtStatut.Text = string.Empty;
            cbMedecin.SelectedIndex = -1;
            cbPatient.SelectedIndex = -1;
            cbSoin.SelectedIndex = -1;

            // Rafraîchir DataGridView
            dgRendezVous.DataSource = null;
            dgRendezVous.DataSource = rendezVousList.Select(rv => new
            {
                rv.IdRv,
                rv.DateRv,
                rv.Statut,
                Medecin = rv.Medecin?.NomPrenom,
                Patient = rv.Patient?.NomPrenom,
                Soin = rv.Soin?.Nom
            }).ToList();

            if (dgRendezVous.Columns.Contains("IdRv"))
                dgRendezVous.Columns["IdRv"].Visible = false;

            dtpDateRv.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            RendezVous rv = new RendezVous
            {
                IdRv = rendezVousList.Count > 0 ? rendezVousList.Max(r => r.IdRv) + 1 : 1,
                DateRv = dtpDateRv.Value,
                Statut = txtStatut.Text,
                Medecin = new Medecin { NomPrenom = cbMedecin.Text },
                Patient = new Patient { NomPrenom = cbPatient.Text },
                Soin = new Soin { Nom = cbSoin.Text }
            };

            rendezVousList.Add(rv);
            ResetForm();
            MessageBox.Show("Rendez-vous ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null)
            {
                int index = dgRendezVous.CurrentRow.Index;
                RendezVous rv = rendezVousList[index];

                rv.DateRv = dtpDateRv.Value;
                rv.Statut = txtStatut.Text;
                rv.Medecin.NomPrenom = cbMedecin.Text;
                rv.Patient.NomPrenom = cbPatient.Text;
                rv.Soin.Nom = cbSoin.Text;

                ResetForm();
                MessageBox.Show("Rendez-vous modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null)
            {
                int index = dgRendezVous.CurrentRow.Index;
                rendezVousList.RemoveAt(index);
                ResetForm();
                MessageBox.Show("Rendez-vous supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null)
            {
                RendezVous rv = rendezVousList[dgRendezVous.CurrentRow.Index];

                dtpDateRv.Value = rv.DateRv;
                txtStatut.Text = rv.Statut;
                cbMedecin.Text = rv.Medecin?.NomPrenom;
                cbPatient.Text = rv.Patient?.NomPrenom;
                cbSoin.Text = rv.Soin?.Nom;
            }
        }

        private void dgRendezVous_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
