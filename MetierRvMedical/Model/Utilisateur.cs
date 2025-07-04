﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical.Model
{
    public class Utilisateur: Personne
    {
        [MaxLength(20)]
        public string Identifiant {  get; set; }
        [MaxLength(255)]
        public string MotDePasse {  get; set; }

        public bool Status {  get; set; }

        public int? IdRole { get; set; }

        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }



    }
}
