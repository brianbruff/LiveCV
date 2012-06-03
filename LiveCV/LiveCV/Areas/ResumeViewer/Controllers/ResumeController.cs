
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
            return View(_context.Resumes.Single(r => r.ResumeId == id));
        }        
    }
}
