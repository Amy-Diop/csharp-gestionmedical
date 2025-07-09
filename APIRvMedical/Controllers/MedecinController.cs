using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    public class MedecinController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/Medecin
        [HttpGet]
        public IEnumerable<Medecin> GetMedecins()
        {
            return db.Medecins.ToList();
        }

        // GET: api/Medecin/5
        [HttpGet]
        public IHttpActionResult GetMedecin(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
                return NotFound();

            return Ok(medecin);
        }

        // POST: api/Medecin
        [HttpPost]
        public IHttpActionResult PostMedecin(Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Medecins.Add(medecin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medecin.IdU }, medecin); // ✅ IdU ici
        }

        // PUT: api/Medecin/5
        [HttpPut]
        public IHttpActionResult PutMedecin(int id, Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Medecins.Find(id);
            if (existing == null)
                return NotFound();

            existing.NumeroOrdre = medecin.NumeroOrdre;
            existing.IdSpecialite = medecin.IdSpecialite;
            existing.NomPrenom = medecin.NomPrenom;
            existing.Email = medecin.Email;
            existing.Tel = medecin.Tel;
            existing.Adresse = medecin.Adresse;

            db.SaveChanges();
            return Ok(existing);
        }

        // DELETE: api/Medecin/5
        [HttpDelete]
        public IHttpActionResult DeleteMedecin(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
                return NotFound();

            db.Medecins.Remove(medecin);
            db.SaveChanges();

            return Ok();
        }
    }
}
