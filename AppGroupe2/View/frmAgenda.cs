using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Helper;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    public partial class frmAgenda : Form
    {
        public int idMedecin;
        Utils utils = new Utils();
        public frmAgenda()
        {
            InitializeComponent();
        }
        BdRvMedicalContext db = new BdRvMedicalContext();
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m = db.Medecins.Find(idMedecin);
            lblMedecin.Text = String.Format("N Ordre: {0}, Nom Prenom: {1}", m.NumeroOrdre, m.NomPrenom);
            lblIdMedecin.Text=m.IdU.ToString();
            lblIdMedecin.Visible = false;
            ResetForm();


        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Agenda a = new Agenda();
                a.Crenaux = int.Parse(txtCreneau.Text);
                a.HeureFin = txtHeureFin.Text;
                a.HeureDebut = txtHeureDebut.Text;
                a.IdMedecin = idMedecin;
                a.DatePlanifie = txtDateAgenda.Value;
                a.lieu = txtLieu.Text;
                a.Titre = txtTitre.Text;
                a.Statut = "Brouillon";
                db.Agenda.Add(a);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                utils.WriteDataError("frmAgenda-btnAjouter_click", ex.ToString());
            }
            finally
            {
                ResetForm();
            }

        }
        private void ResetForm()
        {
            dgAgenda.DataSource = db.Agenda.Where(a => a.DatePlanifie>=DateTime.Now && a.IdMedecin ==idMedecin).ToList();
            txtCreneau.Text = String.Empty;
            txtDateAgenda.Text = String.Empty;
            txtHeureDebut.Text = String.Empty;
            txtHeureFin.Text = String.Empty;
            txtLieu.Text = String.Empty;
            txtTitre.Text = String.Empty;
            txtTitre.Focus();

        }
    }
}
