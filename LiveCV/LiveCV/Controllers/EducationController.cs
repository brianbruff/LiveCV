using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace LiveCV.Controllers
{
    public class EducationController : Controller
    {
        //private Models.LiveCVContext _context = new Models.LiveCVContext(ConfigurationManager.ConnectionStrings["Azure"].ConnectionString);
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();

        //
        // GET: /Education/

        public ActionResult Index()
        {
            return View(_context.Resumes.First().Educations);
        }

        //
        // GET: /Education/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Education/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Education/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Education/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Education/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Education/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Education/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
