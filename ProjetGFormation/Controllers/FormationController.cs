using ProjetGFormation.DataAccess;
using ProjetGFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetGFormation.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public FormationController()
        {
            LesFormationsDAO.FindAll();
        }
        public ActionResult Index()
        {
            return View(LesFormationsDAO.FindAll());
        }

        // GET: Formation/Details/5
        public ActionResult Details(int id)
        {
            return View(LesFormationsDAO.FindByID(id));
        }

        // GET: Formation/Create
        public ActionResult Create()
        {
            return View("Create",new LesFormations());
        }

        // POST: Formation/Create
        [HttpPost]
        public ActionResult Create(LesFormations formation )
        {
            try
            {
                if (ModelState.IsValid)
                {

                    // TODO: Add insert logic here
                    LesFormationsDAO.Create(formation);

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(formation);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Erreur", ex);
                ViewBag.Error = "Un problème est survenu";
                return View(formation);
            }
        }

        // GET: Formation/Edit/5
        public ActionResult Edit(int id)
        {
            return View(LesFormationsDAO.FindByID(id));
        }

        // POST: Formation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LesFormations formation,FormCollection form)
        {



            //string champ = form.GetValues("champSupplementaire").FirstOrDefault();
            //if (!string.IsNullOrWhiteSpace(champ))
            //{
            //    ViewBag.Info = "Champ renseigné : " + champ;
            //    return View();
            //}

            try
            {
                // TODO: Add update logic here
                LesFormationsDAO.Edit(formation); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           
        }

        // GET: Formation/Delete/5
        public ActionResult Delete(int id)
        {
            return View(LesFormationsDAO.FindByID(id));
        }

        // POST: Formation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {


            try
            {
                // TODO: Add delete logic here
                LesFormationsDAO.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }
    }
}
