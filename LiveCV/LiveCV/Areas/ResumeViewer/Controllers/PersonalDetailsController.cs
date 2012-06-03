using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace LiveCV.Areas.ResumeViewer.Controllers
{
    public class PersonalDetailsController : Controller
    {
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();
        //
        // GET: /PersonalDetails/

        public ActionResult Index()
        {
            return View(_context.Resumes.First().PersonalDetails);
        }

        //
        // GET: /PersonalDetails/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PersonalDetails/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /PersonalDetails/Create

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
        // GET: /PersonalDetails/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PersonalDetails/Edit/5

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
        // GET: /PersonalDetails/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PersonalDetails/Delete/5

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
