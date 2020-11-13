using ProjetGFormation.DataAccess;
using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjetGFormation.Controllers
{
    public class LesCursusController : Controller
    {

        public LesCursusController()
        {
            LesCursusDAO.Init();
            LesCursusDAO.FindAll();

        }
        // GET: LesCursus
        public ActionResult Index()
        {

            

            return View(LesCursusDAO.LesCursus);

            
        }
        


        // GET: LesCursus/Details/5
        public ActionResult Details(int id)
        {
            LesCursus c = LesCursusDAO.FindById(id);

            return View(c);

        } 

        // GET: LesCursus/Create
        public ActionResult Create()
        {
            return View(new LesCursus());
        }

        // POST: LesCursus/Create
        [HttpPost]
        public ActionResult Create(LesCursus cursus)
        {


            try
            {
                if (ModelState.IsValid)
                {


                    // TODO: Add insert logic here
                    LesCursusDAO.Create(cursus);


                    return RedirectToAction("Index");
                }
                else
                {

                    return View(cursus);
                }

            }
            catch (Exception ex)
            {
                // on n 'a pas préciser la vue qu'on veut afficher don il va afficher la vue de create 

                ModelState.AddModelError("Erreur", ex);
                ViewBag.Error = "Un problème est survenue ";
                return View(cursus);
            }
           
        }

        // GET: LesCursus/Edit/5
        public ActionResult Edit(int id)
        {
            return View(LesCursusDAO.FindById(id));
        }

        // POST: LesCursus/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LesCursus cursus, FormCollection form)
        {

            try
            {
                // TODO: Add update logic here
                LesCursusDAO.Edit(cursus); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }

        // GET: LesCursus/Delete/5
        public ActionResult Delete(int id)
        {
            return View(LesCursusDAO.FindById(id));
        }

        // POST: LesCursus/Delete/5
        [HttpPost]
        public ActionResult Delete(int id , LesCursus c  )
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            try
            {
                LesCursusDAO.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //return RedirectToAction("Delete", new { id = id, savechagesError = true });
                return View();
            }


          






        }
    }
}
