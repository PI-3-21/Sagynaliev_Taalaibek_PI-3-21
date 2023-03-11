using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class CourierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
