using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    public class AgendaController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        // GET: api/Agenda
        [HttpGet]
        public IEnumerable<Agenda> GetAgendas()
        {
            return db.Agendas.Include("Medecin").Include("RendezVous").ToList();
        }

        // GET: api/Agenda/5
        [HttpGet]
        public IHttpActionResult GetAgenda(int id)
        {
            var agenda = db.Agendas.Include("Medecin").Include("RendezVous").FirstOrDefault(a => a.IdAgenda == id);
            if (agenda == null)
                return NotFound();

            return Ok(agenda);
        }

        // POST: api/Agenda
        [HttpPost]
        public IHttpActionResult PostAgenda(Agenda agenda)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Agendas.Add(agenda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = agenda.IdAgenda }, agenda);
        }

        // PUT: api/Agenda/5
        [HttpPut]
        public IHttpActionResult PutAgenda(int id, Agenda agenda)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Agendas.Find(id);
            if (existing == null)
                return NotFound();

            existing.DatePlanifie = agenda.DatePlanifie;
            existing.Titre = agenda.Titre;
            existing.HeureDebut = agenda.HeureDebut;
            existing.HeureFin = agenda.HeureFin;
            existing.Crenaux = agenda.Crenaux;
            existing.Lieu = agenda.Lieu;
            existing.Statut = agenda.Statut;
            existing.IdMedecin = agenda.IdMedecin;

            db.SaveChanges();
            return Ok(existing);
        }

        // DELETE: api/Agenda/5
        [HttpDelete]
        public IHttpActionResult DeleteAgenda(int id)
        {
            var agenda = db.Agendas.Find(id);
            if (agenda == null)
                return NotFound();

            db.Agendas.Remove(agenda);
            db.SaveChanges();

            return Ok();
        }
    }
}
