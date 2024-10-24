using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {

          ViewBag.Cat = new List<string>{"Teknoloji","Web Tasarim","Kodlama Dilleri"};

            return View();
        }

    }
}
