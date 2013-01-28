
using System.Web.Mvc;
using System.Linq;
using System.Configuration;

namespace LiveCV.Controllers
{
    public class HomeController : Controller
    {
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();

        public ActionResult Index()
        {
            var firstResume = _context.Resumes.First();
            ViewBag.ResumeId = firstResume.ResumeId;
            return View(firstResume);            
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
