using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierRvMedical
{
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        BdRvMedicalContext db = new BdRvMedicalContext();

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /// <summary>
        /// Retourne la liste des agendas
        /// </summary>
        /// <returns></returns>
        public List<Agenda> GetListeAgenda()
        {
            return db.Agenda.ToList();

        }
        /// <summary>
        /// Ajouter des agendas
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public bool AddAgenda(Agenda agenda)
        {
            try
            {
                db.Agenda.Add(agenda);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
        /// <summary>
        /// Modifier la liste des agendas
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public bool UpdateAgenda(Agenda agenda)
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
        /// <summary>
        /// recuperer le medecin a partir de son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Medecin GetMedecinById(int id)
        {
            return db.Medecins.Find(id);
        }
    }
}
