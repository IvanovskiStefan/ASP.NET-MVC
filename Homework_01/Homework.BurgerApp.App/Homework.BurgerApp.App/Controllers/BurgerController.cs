using Microsoft.AspNetCore.Mvc;

namespace Homework.BurgerApp.App.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
