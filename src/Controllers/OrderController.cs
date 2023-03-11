using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
