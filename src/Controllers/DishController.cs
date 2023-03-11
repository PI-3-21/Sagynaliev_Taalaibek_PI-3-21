using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
