using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.Models
{
    public class LesSessionDeFormation
    {
        public int LesSessionDeFormationId { get; set; }
        public string Description { get; set; }
        public List<LeFormateur> LesFormateurs { get; set; }
        public List<LesSessionDeCursus> SessionCursus { get; set; }

    }
}