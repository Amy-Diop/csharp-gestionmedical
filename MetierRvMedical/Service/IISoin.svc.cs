using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "IISoin" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez IISoin.svc ou IISoin.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class IISoin : IIISoin
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        public bool AddSoin(Soin soin)
        {
            try
            {
                db.soins.Add(soin);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public List<Soin> GetListeSoins()
        {
            return db.soins.ToList();
        }

        public Soin GetSoinById(int id)
        {
            return db.soins.Find(id);
           
        }

        public void SupprimerSoin(int id)
        {
            var soin = db.soins.Find(id);
            if (soin != null)
            {
                db.soins.Remove(soin);
                db.SaveChanges();
            }
        }

        public bool UpdateSoin(Soin soin)
        {
            try
            {
                db.Entry(soin).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
