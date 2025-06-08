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
using System.Security.Cryptography;

namespace AppGroupe2
{
    public partial class frmConnexion : Form
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            var leUser = db.Utilisateurs.Where(a=>a.Identifiant.ToLower()==txtIdentifiant.Text.ToLower()).FirstOrDefault();
            if ((leUser != null)&&(CryptString.VerifyMd5Hash(txtMotDePasse.Text, leUser.MotDePasse)))
            {
                frmMDI f = new frmMDI();
                f.role = leUser.Role.Code;
                f.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text ="Identifiant ou mot de passe incorrect";

            }

            //Utils.WriteLogSystem("frmConnection-btnSeConnecter_Click", "Bievenue");
            //GMailer.SenMail("diopamyl3gl@groupeisi.com", "test", "test Envoie Email");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            Utils.WriteLogSystem("test", "Ceci est un test");
            GMailer.SenMail("diopamyl3gl@groupeisi.com", "test", "un test");
           // Utils.WriteLogSystem("frmConnection-btnSeConnecter_Click", "Bievenue");
            //GMailer.SenMail("diopamyl3gl@groupeisi.com", "test", "test Envoie Email");

        }
    }
}
