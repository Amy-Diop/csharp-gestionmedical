using System.ComponentModel.DataAnnotations;

namespace APIRvMedical.Model
{
    public class Specialite
    {
        [Key]
        public int IdSpecialite { get; set; }

        [Required, MaxLength(10)]
        public string CodeSpecialite { get; set; }

        [Required, MaxLength(100)]
        public string NomSpecialite { get; set; }
    }
}
