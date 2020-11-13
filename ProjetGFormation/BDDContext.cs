using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetGFormation
{
    public class BDDContext: DbContext
    {
        public DbSet<LesCursus> Cursus { get; set; }
        public DbSet<LesFormations> Formations { get; set; }
        public DbSet<LesSessionDeCursus> SessionCursus { get; set; }
        public DbSet<LesSessionDeFormation> SessionFormations { get; set; }
        public DbSet<LeFormateur> Formateurs { get; set; }
        public DbSet<LeStagiaire> Stagiaires { get; set; }

    }
}