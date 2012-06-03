using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace LiveCV.Areas.ResumeViewer.Controllers
{
    public class WorkDetailsController : Controller
    {
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View(_context.Resumes.First().WorkDetails.OrderByDescending(wd => wd.Start).ToList());
        }

       // public ActionResult Freelance()
       // {
            //return View(_context.Resumes.First().Freelance.OrderByDescending(wd => wd.Start).ToList());
       // }

        
        //
        // GET: /Work/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Work/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Work/Create

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
        // GET: /Work/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Work/Edit/5

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
        // GET: /Work/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Work/Delete/5

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
