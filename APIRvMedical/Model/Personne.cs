using System.ComponentModel.DataAnnotations;

namespace APIRvMedical.Model
{
    public class Personne
    {
        [Key]
        public int IdU { get; set; }  // Clé primaire unique

        [Required, MaxLength(160)]
        public string NomPrenom { get; set; }

        [Required, MaxLength(200)]
        public string Adresse { get; set; }

        [Required, MaxLength(80), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Tel { get; set; }
    }
}
