using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    public class LesSessionDeFormationDAO
    {
        public static void Create(LesSessionDeFormation ST)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.SessionFormations.Add(ST);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public static List<LesSessionDeFormation> FindAll()
        {

            using (BDDContext context = new BDDContext())
            {
                return context.SessionFormations.ToList();

            }
        }

        public static void Insert(LesSessionDeFormation St)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.SessionFormations.Add(St);
                    context.SaveChanges();
                }

            }

            catch (Exception ex)
            {

            }

        }

        public static void Update(LesSessionDeFormation St)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {

                    LesSessionDeFormation Sf = context.SessionFormations.FirstOrDefault(S => S.LesSessionDeFormationId == St.LesSessionDeFormationId);
                    Sf.Description = St.Description;
                    Sf.LesFormateurs = St.LesFormateurs;
                    Sf.SessionCursus = St.SessionCursus;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}