using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    [RoutePrefix("api/soins")]
    public class SoinController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/soins
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var soins = db.Soins.ToList();
            return Ok(soins);
        }

        // GET: api/soins/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var soin = db.Soins.Find(id);
            if (soin == null)
                return NotFound();

            return Ok(soin);
        }

        // POST: api/soins
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] Soin soin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Soins.Add(soin);
            db.SaveChanges();

            return Created($"api/soins/{soin.IdSoin}", soin);
        }

        // PUT: api/soins/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] Soin soin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Soins.Find(id);
            if (existing == null)
                return NotFound();

            existing.Nom = soin.Nom;
            existing.Description = soin.Description;
            existing.Prix = soin.Prix;
            existing.Libelle = soin.Libelle;
            existing.Cout = soin.Cout;

            db.SaveChanges();

            return Ok(existing);
        }

        // DELETE: api/soins/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var soin = db.Soins.Find(id);
            if (soin == null)
                return NotFound();

            db.Soins.Remove(soin);
            db.SaveChanges();

            return Ok();
        }
    }
}
