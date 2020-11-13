using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetGFormation.DataAccess
{
    //public static List<Produit> Produits { get; set; }
  
    public class LesCursusDAO
    {
        public static List<LesCursus> LesCursus { get; set; }
      
        public  static LesCursus FindById(int id)
        {
            using (BDDContext context = new BDDContext())
            {

                LesCursus c = context.Cursus.FirstOrDefault(s => s.LesCursusId == id);
                return (c);
               
            }
        }

        public static void Init()
        {
            if (LesCursus == null)
            {
                LesCursus = new List<LesCursus>
                {
                    new LesCursus
                    {
                        Titre="Concepteur Developpeur d'application en .Net FullStack",
                        Description="Cette formation est de 3 mois suivi d'une année d'alterance  ",
                        Duree="3 mois "
                    },
                      new LesCursus
                    {
                        Titre="Concepteur Developpeur d'application en Java",
                        Description="Cette formation est de 4 mois suivi d'une année d'alterance  ",
                        Duree="4 mois "
                    },
                };
                
            }
           
             
        }
        public static void Create(LesCursus cursus)
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {

                    context.Cursus.Add(cursus); 
                    
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public static List<LesCursus> FindAll()
        {

            using (BDDContext context = new BDDContext())
            {
                if (LesCursus != null)
                {
                    LesCursus = context.Cursus.ToList();
                }
                
                return LesCursus;

            }
        }
        public static void Edit(LesCursus cursus)
        {

            
                using (BDDContext context = new BDDContext())
                {

                LesCursus c = FindById(cursus.LesCursusId);

                if ( c  != null){
                    c.Titre = cursus.Titre;
                    c.Description = cursus.Description;

                }

                                     
                
                
                    //c.Formations = cursus.Formations;
                    //c.CursusSuivi = cursus.CursusSuivi;

                    context.SaveChanges();
                }
            
            //catch (Exception ex)
            //{

            //}
        }

        public static void  Delete(int i )
        {
            try
            {
                using (BDDContext context = new BDDContext())
                {
                    

                    context.Cursus.Remove(FindById(i)); 

                        context.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
               
            
        }
    }
}