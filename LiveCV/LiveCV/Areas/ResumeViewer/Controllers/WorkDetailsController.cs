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

        public ActionResult Index(int id)
        {
            return View(_context.Resumes.Single(r => r.ResumeId == id).WorkDetails.OrderByDescending(wd => wd.Start).ToList());
        }

       
    }
}
