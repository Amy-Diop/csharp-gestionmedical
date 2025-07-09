using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    public class SpecialiteController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        [HttpGet]
        public IEnumerable<Specialite> GetSpecialites()
        {
            return db.Specialites.ToList();
        }

        [HttpGet]
        public IHttpActionResult GetSpecialite(int id)
        {
            var specialite = db.Specialites.Find(id);
            if (specialite == null)
                return NotFound();

            return Ok(specialite);
        }

        [HttpPost]
        public IHttpActionResult PostSpecialite(Specialite specialite)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Specialites.Add(specialite);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = specialite.IdSpecialite }, specialite); // ✅ IdSpecialite ici
        }

        [HttpPut]
        public IHttpActionResult PutSpecialite(int id, Specialite specialite)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Specialites.Find(id);
            if (existing == null)
                return NotFound();

            existing.NomSpecialite = specialite.NomSpecialite;
            db.SaveChanges();

            return Ok(existing);
        }

        [HttpDelete]
        public IHttpActionResult DeleteSpecialite(int id)
        {
            var specialite = db.Specialites.Find(id);
            if (specialite == null)
                return NotFound();

            db.Specialites.Remove(specialite);
            db.SaveChanges();

            return Ok();
        }
    }
}
