using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    public class LeStagiaireDAO
    {
        public static void Create(LeStagiaire stagiaire)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Stagiaires.Add(stagiaire);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }


        public static void Createmany(params LeStagiaire[] stagiaires)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Stagiaires.AddRange(stagiaires);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public static List<LeStagiaire> FindAll()
        {

            using (BDDContext context = new BDDContext())
            {
                return context.Stagiaires.ToList();

            }
        }

        public static LeStagiaire FindById(int Idstagiaire)
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Stagiaires.FirstOrDefault(S => S.LeStagiaireId == Idstagiaire);
            }
        }

        public static void Insert(LeStagiaire nouveauStagiaire)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {
                    context.Stagiaires.Add(nouveauStagiaire);
                    context.SaveChanges();
                }

            }

            catch (Exception ex)
            {

            }

        }

        public static void Update(LeStagiaire stagiaire)
        {

            try
            {
                using (BDDContext context = new BDDContext())
                {

                    LeStagiaire S = context.Stagiaires.FirstOrDefault(s => s.LeStagiaireId == stagiaire.LeStagiaireId);
                    S.Nom = stagiaire.Nom;
                    S.Prenom = stagiaire.Prenom;
                    S.Mot_De_Passe = stagiaire.Mot_De_Passe;
                    S.SessionsCursus = stagiaire.SessionsCursus;
                    S.E_mail = stagiaire.E_mail;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}