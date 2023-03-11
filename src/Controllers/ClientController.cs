using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
