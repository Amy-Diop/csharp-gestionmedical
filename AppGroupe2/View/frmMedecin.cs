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
using Microsoft.EntityFrameworkCore;
using AppGroupe2.Helper;

namespace AppGroupe2.View
{
    public partial class frmMedecin : Form
    {
        //BdRvMedicalContext db = new BdRvMedicalContext();
        ServiceMedecin.IIMedecin service = new ServiceMedecin.IMedecinClient();

        public frmMedecin()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ServiceMedecin.Medecin m = new ServiceMedecin.Medecin();

            m.Adresse = txtAdresse.Text;
            m.NumeroOrdre = txtNumeroOrdreMedecin.Text;
            m.Email = txtEmail.Text;
            m.NomPrenom = txtNomPrenom.Text;
            m.Tel = txtTel.Text;
            m.IdSpecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
            m.Identifiant = txtIdentifiant.Text;
            m.MotDePasse = CryptString.GetMd5Hash("P@sser1234");
            var role = service.GetRoleByCode("Med");
            if (role != null)
            {
                m.IdRole = role.Id;
            }
;
            m.Status = false;
            //db.Medecins.Add(m);
            //db.SaveChanges();
            service.AddMedecin(m);
            ResetForm();

        }
        private void ResetForm()
        {
            txtAdresse.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtIdentifiant.Text = String.Empty;
            cbbSpecialite.SelectedValue = String.Empty;
            txtTel.Text = String.Empty;
            txtNomPrenom.Text = String.Empty;
            txtNumeroOrdreMedecin.Text = String.Empty;
            cbbSpecialite.DataSource = LoadCbbSpecialite();
            cbbSpecialite.ValueMember = "Value";
            cbbSpecialite.DisplayMember = "Text";
            dgMedecin.DataSource = service.GetListeMedecin()
                .Select(a => new
                {
                    a.IdU,
                    a.NumeroOrdre,
                    a.Identifiant,
                    NomSpecialite = a.Specialite?.NomSpecialite,
                    a.NomPrenom,
                    a.Tel,
                    a.Email
                }).ToList();
            txtNomPrenom.Focus();



        }


        private void btnChoisir_Click(object sender, EventArgs e)
{
    if (dgMedecin.CurrentRow == null) return;

    int? id = dgMedecin.CurrentRow.Cells[0].Value as int?;
    if (id == null) return;

    using (var dbContext = new BdRvMedicalContext()) // Changer 'db' par 'dbContext'
    {
        var medecin = dbContext.Medecins.Include(m => m.Specialite).FirstOrDefault(x => x.IdU == id);
        if (medecin != null)
        {
            txtAdresse.Text = medecin.Adresse;
            txtEmail.Text = medecin.Email;
            txtIdentifiant.Text = medecin.Identifiant;
            txtNomPrenom.Text = medecin.NomPrenom;
            txtNumeroOrdreMedecin.Text = medecin.NumeroOrdre;
            txtTel.Text = medecin.Tel;

            // Vérification et affectation correcte de l'ID Spécialité
            Console.WriteLine("ID Spécialité du médecin sélectionné : " + (medecin.IdSpecialite?.ToString() ?? "NULL"));
            if (medecin.IdSpecialite != null)
            {
                cbbSpecialite.SelectedValue = medecin.IdSpecialite.Value;
            }
            else
            {
                cbbSpecialite.SelectedIndex = 0; // Sélectionne "Sélectionnez..."
            }
        }
    }
}
        private void btnModidier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = service.GetMedecinById(id);
            m.Adresse = txtAdresse.Text;
            m.NumeroOrdre = txtNumeroOrdreMedecin.Text;
            m.Email = txtEmail.Text;
            m.NomPrenom = txtNomPrenom.Text;
            m.Tel = txtTel.Text;
            m.IdSpecialite = int.Parse(cbbSpecialite.SelectedValue.ToString());
            m.Identifiant = txtIdentifiant.Text;
            //db.SaveChanges();
            service.UpdateMedecin(m);
            ResetForm();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMedecin.CurrentRow != null)
            {
                int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());

                // Appel au service pour suppression
                service.SupprimerMedecin(id);

                // Actualisation du formulaire
                ResetForm();
            }
        }


        private void frmMedecin_Load(object sender, EventArgs e)
        {
            ResetForm();
        }


        private List<SelectListViewModel> LoadCbbSpecialite()
        {
            var specialites = service.GetAllSpecialites(); // appel via WCF
            List<SelectListViewModel> liste = new List<SelectListViewModel>();

            // Élément par défaut
            liste.Add(new SelectListViewModel { Text = "Selectionnez .......", Value = "" });

            foreach (var s in specialites)
            {
                liste.Add(new SelectListViewModel
                {
                    Text = s.NomSpecialite,
                    Value = s.IdSpecialite.ToString()
                });
            }

            return liste;
        }


        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda a = new frmAgenda();
            a.idMedecin = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            a.Show();
        }
    }
}
