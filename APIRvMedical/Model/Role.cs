using System.ComponentModel.DataAnnotations;

namespace APIRvMedical.Model
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(100)]
        public string Libelle { get; set; }
    }
}
