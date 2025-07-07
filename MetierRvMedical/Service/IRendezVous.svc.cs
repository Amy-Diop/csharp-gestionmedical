using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    public class IRendezVous : IIRendezVous
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        public RendezVous GetRendezVousById(int id)
        {
            return db.RendezVous.Find(id);
        }

        public bool AddRendezVous(RendezVous rv)
        {
            try
            {
                db.RendezVous.Add(rv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateRendezVous(RendezVous rv)
        {
            try
            {
                db.Entry(rv).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteRendezVous(int id)
        {
            var rv = db.RendezVous.Find(id);
            if (rv != null)
            {
                db.RendezVous.Remove(rv);
                db.SaveChanges();
            }
        }

        public List<RendezVous> GetAllRendezVous()
        {
            return db.RendezVous.ToList();
        }
    }
}
