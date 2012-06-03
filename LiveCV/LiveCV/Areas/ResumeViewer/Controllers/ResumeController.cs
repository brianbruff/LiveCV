
using System.Web.Mvc;
using System.Linq;
using System.Configuration;

namespace LiveCV.Areas.ResumeViewer.Controllers
{
    public class ResumeController : Controller
    {        
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();
        
        public ActionResult Index(int id)
        {
            TempData["ResumeId"] = id.ToString();
            var resume = _context.Resumes.Single(r => r.ResumeId == id);
            ViewBag.Website = resume.PersonalDetails.Website;
            return View(resume);
        }        
    }
}
