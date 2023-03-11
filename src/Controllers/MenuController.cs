using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
