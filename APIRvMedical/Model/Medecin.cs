using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public object Nom { get; internal set; }
        public object Prenom { get; internal set; }
        public object Id { get; internal set; }
    }
}
