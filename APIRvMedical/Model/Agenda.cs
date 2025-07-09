using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRvMedical.Model
{
    public class Agenda
    {
        [Key]
        public int IdAgenda { get; set; } // ✅ Clé primaire

        public DateTime? DatePlanifie { get; set; }

        [MaxLength(100)]
        public string Titre { get; set; }

        [MaxLength(10)]
        public string HeureDebut { get; set; }

        [MaxLength(10)]
        public string HeureFin { get; set; }

        public int Crenaux { get; set; }

        [MaxLength(200)]
        public string Lieu { get; set; }

        [MaxLength(20)]
        public string Statut { get; set; }

        // ForeignKey vers Medecin
        public int IdMedecin { get; set; }

        [ForeignKey("IdMedecin")]
        public virtual Medecin Medecin { get; set; }

        // Liste des RendezVous liés
        public virtual ICollection<RendezVous> RendezVous { get; set; }
    }
}
