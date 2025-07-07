using System;
using System.Collections.Generic;
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

        private void ResetForm()
        {
            dtpDateRv.Value = DateTime.Now;
            txtStatut.Text = string.Empty;
            cbMedecin.SelectedIndex = -1;
            cbPatient.SelectedIndex = -1;
            cbSoin.SelectedIndex = -1;
            dgRendezVous.DataSource = null;
            dgRendezVous.DataSource = rendezVousList;
        }

        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            // Exemple : liste des médecins, patients et soins
            cbMedecin.DataSource = new List<string> { "Dr Fall", "Dr Ndiaye", "Dr Sow" };
            cbPatient.DataSource = new List<string> { "Patient A", "Patient B", "Patient C" };

            var soins = new List<Soin>
            {
                new Soin { IdSoin = 1, Nom = "Consultation", Prix = 1000 },
                new Soin { IdSoin = 2, Nom = "Vaccin", Prix = 5000 },
                new Soin { IdSoin = 3, Nom = "Suivi", Prix = 2000 }
            };

            cbSoin.DataSource = soins;
            cbSoin.DisplayMember = "Nom";  // Affiche le Nom dans la ComboBox
            cbSoin.ValueMember = "IdSoin"; // Permet de récupérer l’Id si besoin

            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            RendezVous rv = new RendezVous
            {
                DateRv = dtpDateRv.Value,
                Statut = txtStatut.Text,
                Medecin = new Medecin { NomPrenom = cbMedecin.Text },
                patient = new Patient { NomPrenom = cbPatient.Text },
                Soin = cbSoin.SelectedItem as Soin
            };

            rendezVousList.Add(rv);
            ResetForm();
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
                rv.patient.NomPrenom = cbPatient.Text;
                rv.Soin = cbSoin.SelectedItem as Soin;
                ResetForm();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null)
            {
                int index = dgRendezVous.CurrentRow.Index;
                rendezVousList.RemoveAt(index);
                ResetForm();
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
                cbPatient.Text = rv.patient?.NomPrenom;
                cbSoin.Text = rv.Soin?.Nom;
            }
        }
    }
}
