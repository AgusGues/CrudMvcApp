using Microsoft.AspNetCore.Mvc;

namespace CrudMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Products");
        }
    }
}
