using System.ComponentModel.DataAnnotations;

namespace AppGroupe2.Model
{
    public class Soin
    {

        [Key]
        public int IdSoin { get; set; }

        [Required]
        [StringLength(100)]
        public string Nom { get; set; }

        [StringLength(250)]
        public string Description { get; set; }  

        [Range(0, 10000)]
        public decimal Prix { get; set; } 
        [MaxLength(200)]
        public string Libelle { get; set; }

        public float Cout { get; set; }
    

    }
}
