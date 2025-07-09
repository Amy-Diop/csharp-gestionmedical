using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    [RoutePrefix("api/rendezvous")]
    public class RendezVousController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/rendezvous
        [HttpGet, Route("")]
        public IHttpActionResult GetAll()
        {
            var rvs = db.RendezVous.ToList();
            return Ok(rvs);
        }

        // GET: api/rendezvous/5
        [HttpGet, Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var rv = db.RendezVous.Find(id);
            if (rv == null)
                return NotFound();
            return Ok(rv);
        }

        // POST: api/rendezvous
        [HttpPost, Route("")]
        public IHttpActionResult Create(RendezVous rv)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.RendezVous.Add(rv);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rv.IdRv }, rv);
        }

        // PUT: api/rendezvous/5
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Update(int id, RendezVous rv)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != rv.IdRv)
                return BadRequest("Id mismatch");

            var existing = db.RendezVous.Find(id);
            if (existing == null)
                return NotFound();

            db.Entry(existing).CurrentValues.SetValues(rv);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/rendezvous/5
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var rv = db.RendezVous.Find(id);
            if (rv == null)
                return NotFound();

            db.RendezVous.Remove(rv);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
