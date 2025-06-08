﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MetierRvMedical.Model
{
    public class Patient: Personne
    {
        [Required, MaxLength(3)]
        public string GroupeSanguin { get; set; }

        [Required]
        public float? Poids { get; set; }

        [Required]
        public float? Taille { get; set; }
        public DateTime? DateNaissance { get; set; }

    }

}
