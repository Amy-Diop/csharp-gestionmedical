using System.ComponentModel.DataAnnotations;

namespace AppGroupe2.Model
{
    public class Soin
    {

        [Key]
        public int IdSoin { get; set; }

<<<<<<< HEAD
        [Required]
        [StringLength(100)]
        public string Nom { get; set; }  // Nom du soin

        [StringLength(250)]
        public string Description { get; set; }  // Description optionnelle

        [Range(0, 10000)]
        public decimal Prix { get; set; } // Prix du soin
=======
        [MaxLength(200)]
        public string libelle { get; set; }

        public float cout { get; set; }
    
>>>>>>> 7dca2b7eded134c4a8b98e40ec5cd32df444e37b
    }
}
