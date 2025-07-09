using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIRvMedical.Model
{
    public class Utilisateur : Personne
    {
        [MaxLength(20)]
        public string Identifiant { get; set; }

        [MaxLength(255)]
        public string MotDePasse { get; set; }

        public bool Status { get; set; }

        public int? IdRole { get; set; }

        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }
    }
}
