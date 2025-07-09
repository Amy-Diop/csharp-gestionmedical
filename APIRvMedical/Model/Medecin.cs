using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIRvMedical.Model
{
    public class Medecin : Utilisateur
    {
        public int? IdSpecialite { get; set; }

        [ForeignKey("IdSpecialite")]
        public virtual Specialite Specialite { get; set; }

        [MaxLength(10)]
        public string NumeroOrdre { get; set; }

        public virtual ICollection<Agenda> Agendas { get; set; }
        public virtual ICollection<RendezVous> RendezVous { get; set; }
    }
}
