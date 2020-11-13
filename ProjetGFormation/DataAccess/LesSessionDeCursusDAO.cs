using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    public class LesSessionDeCursusDAO
    {
        public static void Create(LesSessionDeCursus Sc)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.SessionCursus.Add(Sc);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static List<LesSessionDeCursus> FindAll()
        {

            using (BDDContext context = new BDDContext())
            {
                return context.SessionCursus.ToList();

            }
        }

        public static void Insert(LesSessionDeCursus Sc)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.SessionCursus.Add(Sc);
                    context.SaveChanges();
                }

            }

            catch (Exception ex)
            {

            }

        }

        public static void Update(LesSessionDeCursus Sc)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {

                    LesSessionDeCursus Sfc = context.SessionCursus.FirstOrDefault(s => s.LesSessionDeCursusId == Sc.LesSessionDeCursusId);

                    Sfc.Description = Sc.Description;
                    //Sfc.Stagiaires = Sc.Stagiaires;
                    Sfc.SessionFormations = Sc.SessionFormations;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}