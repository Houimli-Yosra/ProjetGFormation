using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LeFormateur
    {
        public int LeFormateurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mot_De_Passe { get; set; }
        [MaxLength(50)]
        public string E_mail { get; set; }

        public List<LesSessionDeFormation> SessionsFormations { get; set; }
    }
}