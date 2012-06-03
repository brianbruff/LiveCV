
using System.Web.Mvc;
using System.Linq;
using System.Configuration;

namespace LiveCV.Areas.ResumeViewer.Controllers
{
    public class ResumeController : Controller
    {
        //private Models.LiveCVContext _context = new Models.LiveCVContext(ConfigurationManager.ConnectionStrings["Azure"].ConnectionString);
        LiveCV.Models.LiveCVContext _context = new Models.LiveCVContext();

        public ActionResult Index()
        {
            return View(_context.Resumes.First());            
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
