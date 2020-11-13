using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LeStagiaire
    {
        public int LeStagiaireId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [MaxLength(50)]
        public string E_mail { get; set; }
        public string Url { get; set; }
        public DateTime Date_de_Naissance { get; set; }
        [MaxLength(8)]
        public string Mot_De_Passe { get; set; }
        public List<LesSessionDeCursus> SessionsCursus { get; set; }
    }
}