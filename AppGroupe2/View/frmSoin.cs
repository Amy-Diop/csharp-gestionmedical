using AppGroupe2.Model;
using System;
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
    public partial class frmSoin : Form
    {
        ServiceSoin.IISoinClient service = new ServiceSoin.IISoinClient();
        
        public frmSoin()
        {
            InitializeComponent();
        }

        private void frmSoin_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceSoin.Soin  s = new ServiceSoin.Soin();
                s.libelle = txtLibelle.Text.Trim();
                s.cout = float.Parse(txtCout.Text.Trim());

                if (s.IdSoin == 0)
                {
                    // Ajout
                    service.AddSoin(s);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
            finally
            {
                ResetForm();
            }
        }


        private void btnModidier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSoins.CurrentRow.Cells[0].Value.ToString());
            var m = service.GetSoinById(id);

            m.cout = float.Parse(txtCout.Text.Trim());
            m.libelle = txtLibelle.Text.Trim();

            service.UpdateSoin(m);
            ResetForm();
        }



        private void dgSoins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResetForm()
        {
            try
            {
                dgSoins.DataSource = null;
                dgSoins.DataSource = service.GetListeSoins();

                txtLibelle.Text = string.Empty;
                txtCout.Text = string.Empty;
                txtLibelle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoins.CurrentRow != null)
            {
                int id = int.Parse(dgSoins.CurrentRow.Cells[0].Value.ToString());

                // Appel au service pour suppression
                service.SupprimerSoin(id);

                // Actualisation du formulaire
                ResetForm();
            }
        }


        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
