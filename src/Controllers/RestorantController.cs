using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class RestorantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
