using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.View;
using AppGroupe2.Model;

namespace AppGroupe2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
            CreateAdmin();
        }
        static void CreateAdmin()
        {
            BdRvMedicalContext db = new BdRvMedicalContext();
            int AdminExist = db.admins.Count();
            if (AdminExist == 0) 
                {
                Admin admin = new Admin();
                admin.Adresse = "Admin-Adresse";
                admin.Identifiant = "Admin";
                admin.Status = true;
                admin.Tel = "tel-Admin";
                admin.MotDePasse = Helper.CryptString.GetMd5Hash("P@sser1234");
                admin.NomPrenom = "Nom-Prenom";
                admin.Email = "l3gl@yopmail.com";
                admin.IdRole = db.roles.Where(a => a.Code.ToLower()=="admin").FirstOrDefault().Id;
                db.admins.Add(admin);
                db.SaveChanges();

            }
        }
    }
}
