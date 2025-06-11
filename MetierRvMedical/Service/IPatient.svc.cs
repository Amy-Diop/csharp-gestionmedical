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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "IPatient" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez IPatient.svc ou IPatient.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class IPatient : IIPatient
    {
        BdRvMedicalContext db = new BdRvMedicalContext();
        /// <summary>
        /// Retourne la Liste des Patients
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetListePatients()
        {
            return db.Patients.ToList();
        }

        public bool AddPatient(Patient patient)
        {
            try
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>

        public bool UpdatePatient(Patient patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SupprimerPatient(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient != null)
            {
                db.Patients.Remove(patient);
                db.SaveChanges();
            }
        }
        public Patient GetPatientById(int id)
        {
            return db.Patients.Find(id);
        }



    }
}
