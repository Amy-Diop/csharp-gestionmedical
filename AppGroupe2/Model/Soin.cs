using System.ComponentModel.DataAnnotations;

namespace AppGroupe2.Model
{
    public class Soin
    {
        [Key]
        public int IdSoin { get; set; }

        [Required]
        [StringLength(100)]
        public string Nom { get; set; }  // Nom du soin

        [StringLength(250)]
        public string Description { get; set; }  // Description optionnelle

        [Range(0, 10000)]
        public decimal Prix { get; set; } // Prix du soin
    }
}
