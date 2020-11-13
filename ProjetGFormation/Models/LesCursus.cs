using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LesCursus
    {

        public int LesCursusId { get; set; }
        public string Titre { get; set;  }
        public string Url { get; set; }
        public string Duree { get; set;  }
        public string Description { get; set; }
        public List<LesFormations> Formations { get; set; }
    }
}