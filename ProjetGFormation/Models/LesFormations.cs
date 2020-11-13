using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LesFormations
    {
        public int LesFormationsId { get; set; }
        public string titre { get; set; }
        public string Description { get; set; }
        public List<LesCursus> LesCursus_suivi { get; set; }

        //public List<LesSessionDeFormation>SessionsFormations { get; set; }
    }
}