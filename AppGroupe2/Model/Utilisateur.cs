using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Utilisateur: Personne
    {
        [MaxLength(20)]
        public string Identifiant {  get; set; }
        [MaxLength(255)]
        public string MotDePass {  get; set; }

        public bool Status {  get; set; }

    }
}
