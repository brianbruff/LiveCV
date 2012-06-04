﻿using System;
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

        public ActionResult Index(int id)
        {
            var resume = _context.Resumes.Single(r => r.ResumeId == id);
            ViewBag.ResumeId = id.ToString();
            ViewBag.Website = resume.PersonalDetails.Website;
            return View(resume.PersonalDetails);
        }
    }
}
