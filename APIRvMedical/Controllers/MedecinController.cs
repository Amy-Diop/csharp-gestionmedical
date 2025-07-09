using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    [RoutePrefix("api/medecins")]
    public class MedecinController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/medecins
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllMedecins()
        {
            var medecins = db.Medecins
                .Select(m => new
                {
                    m.Id,
                    m.Nom,
                    m.Prenom,
                    m.NumeroOrdre,
                    Specialite = m.Specialite != null ? new
                    {
                        m.Specialite.IdSpecialite,
                        m.Specialite.NomSpecialite
                    } : null
                }).ToList();

            return Ok(medecins);
        }

        // GET: api/medecins/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetMedecinById(int id)
        {
            var medecin = db.Medecins
                .Where(m => m.Id == id)
                .Select(m => new
                {
                    m.Id,
                    m.Nom,
                    m.Prenom,
                    m.NumeroOrdre,
                    Specialite = m.Specialite != null ? new
                    {
                        m.Specialite.IdSpecialite,
                        m.Specialite.NomSpecialite
                    } : null
                }).FirstOrDefault();

            if (medecin == null)
            {
                return NotFound();
            }

            return Ok(medecin);
        }

        // POST: api/medecins
        [HttpPost]
        [Route("")]
        public IHttpActionResult AddMedecin([FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                db.Medecins.Add(medecin);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = medecin.Id }, medecin);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT: api/medecins/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateMedecin(int id, [FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingMedecin = db.Medecins.Find(id);
            if (existingMedecin == null)
            {
                return NotFound();
            }

            // Mettre à jour les propriétés
            existingMedecin.Nom = medecin.Nom;
            existingMedecin.Prenom = medecin.Prenom;
            existingMedecin.NumeroOrdre = medecin.NumeroOrdre;
            existingMedecin.IdSpecialite = medecin.IdSpecialite;

            try
            {
                db.SaveChanges();
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/medecins/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteMedecin(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
            {
                return NotFound();
            }

            try
            {
                db.Medecins.Remove(medecin);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/medecins/specialites
        [HttpGet]
        [Route("specialites")]
        public IHttpActionResult GetAllSpecialites()
        {
            var specialites = db.Specialite
                .Select(s => new
                {
                    s.IdSpecialite,
                    s.NomSpecialite
                }).ToList();

            return Ok(specialites);
        }
    }
}
