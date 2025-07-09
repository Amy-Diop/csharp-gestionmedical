using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using APIRvMedical.Model;

namespace APIRvMedical.Controllers
{
    public class PatientController : ApiController
    {
        private readonly BdRvMedicalContext db = new BdRvMedicalContext();

        [HttpGet]
        public IEnumerable<Patient> GetPatients()
        {
            return db.Patients.ToList();
        }

        [HttpGet]
        public IHttpActionResult GetPatient(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        [HttpPost]
        public IHttpActionResult PostPatient(Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Patients.Add(patient);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patient.IdU }, patient); // ✅ IdU
        }

        [HttpPut]
        public IHttpActionResult PutPatient(int id, Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Patients.Find(id);
            if (existing == null)
                return NotFound();

            existing.NomPrenom = patient.NomPrenom;
            existing.Adresse = patient.Adresse;
            existing.Email = patient.Email;
            existing.Tel = patient.Tel;

            db.SaveChanges();
            return Ok(existing);
        }

        [HttpDelete]
        public IHttpActionResult DeletePatient(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
                return NotFound();

            db.Patients.Remove(patient);
            db.SaveChanges();

            return Ok();
        }
    }
}
