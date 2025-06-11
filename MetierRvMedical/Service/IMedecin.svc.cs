using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "IMedecin" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez IMedecin.svc ou IMedecin.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class IMedecin : IIMedecin
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        /// <summary>
        /// recuperer le medecin a partir de son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Medecin GetMedecinById(int id)
        {
            return db.Medecins.Find(id);
        }
        public bool AddMedecin(Medecin medecin)
        {
            try
            {
                db.Medecins.Add(medecin);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public Role GetRoleById(int id)
        {
            return db.roles.Find(id);
        }

        public Role GetRoleByCode(string code)
        {
            var role = db.roles.FirstOrDefault(r => r.Code == code);
            if (role == null) return null;
            return new Role
            {
                Id = role.Id,
                Code = role.Code,
                Libelle = role.Libelle
            };
        }

        bool UpdateMedecin(Medecin agenda)
        {
            try
            {
                db.Entry(agenda).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        List<Medecin> GetListeMedecin()
        {
            return db.Medecins.ToList();
        }

        bool IIMedecin.UpdateMedecin(Medecin agenda)
        {
            return UpdateMedecin(agenda);
        }


        public void SupprimerMedecin(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin != null)
            {
                db.Medecins.Remove(medecin);
                db.SaveChanges();
            }
        }
        public List<Specialite> GetAllSpecialites()
        {
            return db.Specialite.Select(s => new Specialite
            {
                IdSpecialite = s.IdSpecialite,
                NomSpecialite = s.NomSpecialite
            }).ToList();
        }

        Medecin IIMedecin.GetMedecinById(int id)
        {
            throw new NotImplementedException();
        }

        bool IIMedecin.AddMedecin(Medecin medecin)
        {
            throw new NotImplementedException();
        }

        Role IIMedecin.GetRoleById(int id)
        {
            throw new NotImplementedException();
        }

        Role IIMedecin.GetRoleByCode(string code)
        {
            throw new NotImplementedException();
        }

        List<Medecin> IIMedecin.GetListeMedecin()
        {
            throw new NotImplementedException();
        }

        void IIMedecin.SupprimerMedecin(int id)
        {
            throw new NotImplementedException();
        }

        List<Specialite> IIMedecin.GetAllSpecialites()
        {
            throw new NotImplementedException();
        }
    }
}
