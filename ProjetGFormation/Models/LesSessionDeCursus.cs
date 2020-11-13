using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LesSessionDeCursus
    {
        public int LesSessionDeCursusId { get; set; }
        public string Description { get; set; }
        public string url { get; set; }
        //public List<LeStagiaire> ListeStagiaires { get; set; }

        public List<LesSessionDeFormation> SessionFormations { get; set; }
    }
}