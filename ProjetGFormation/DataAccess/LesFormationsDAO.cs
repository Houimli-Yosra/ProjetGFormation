using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    public class LesFormationsDAO
    {
        public static void Create(LesFormations formation)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Formations.Add(formation);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static List<LesFormations> FindAll()
        {

            using (BDDContext context = new BDDContext())
            {
                return context.Formations.ToList();

            }
        }

        public static LesFormations FindByID(int id)
        {
            using (BDDContext context = new BDDContext())
            {

                LesFormations f = context.Formations.FirstOrDefault(s => s.LesFormationsId == id);
                return (f);

            }
        }

        public static void Edit(LesFormations formation)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {

                    LesFormations f = context.Formations.FirstOrDefault(s => s.LesFormationsId == formation.LesFormationsId);

                    f.titre = formation.titre;
                    f.Description = formation.Description;
                    f.LesCursus_suivi = formation.LesCursus_suivi;
                    //f.SessionFormations = formation.SessionFormations;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static void Delete(int id)
        {
            using (BDDContext context = new BDDContext())
            {
                context.Formations.Remove(FindByID(id));
                context.SaveChanges();
            }
        }
    }
}