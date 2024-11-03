using Microsoft.AspNetCore.Mvc;

namespace MediPlusApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
  
        public ActionResult Index()
        {
            return View();
        }

    }
}
