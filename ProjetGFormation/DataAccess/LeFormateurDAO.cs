using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    public class LeFormateurDAO
    {

        public static void Create(LeFormateur formateur)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Formateurs.Add(formateur);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static void Createmany(params LeFormateur[] formateurs)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Formateurs.AddRange(formateurs);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public static List<LeFormateur> FindAll()
        {




            using (BDDContext context = new BDDContext())
            {
                return context.Formateurs.ToList();



            }
        }



        public static void Insert(LeFormateur nouveauformateur)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Formateurs.Add(nouveauformateur);
                    context.SaveChanges();
                }

            }

            catch (Exception ex)
            {

            }

        }

        public static void Update(LeFormateur formateur)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {

                    LeFormateur f = context.Formateurs.FirstOrDefault(F => F.LeFormateurId == formateur.LeFormateurId);
                    f.Nom = formateur.Nom;
                    f.Prenom = formateur.Prenom;
                    f.Mot_De_Passe = formateur.Mot_De_Passe;
                    f.SessionsFormations = formateur.SessionsFormations;
                    f.E_mail = formateur.E_mail;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static void Delete(int id)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {

                    context.Formateurs.Remove(context.Formateurs.FirstOrDefault(f => f.LeFormateurId == id));

                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}