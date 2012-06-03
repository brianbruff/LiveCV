
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
            return View(_context.Resumes.First());            
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
