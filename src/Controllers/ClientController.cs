using EatAndDrink.Models;
using Microsoft.AspNetCore.Mvc;

namespace EatAndDrink.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            Client client1 = new Client() { Id = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "0702350302", Address = "Bishkek, Manasa 1" };
            Client client2 = new Client() { Id = 2, FirstName = "Ivan", LastName = "Ivanov", PhoneNumber = "0225601100", Address = "Bishkek, Manasa 2" };
            Client client3 = new Client() { Id = 3, FirstName = "Sergio", LastName = "Olson", PhoneNumber = "0505601100", Address = "Bishkek, Manasa 3" };
            Client client4 = new Client() { Id = 4, FirstName = "Ritthy", LastName = "Adams", PhoneNumber = "0559091010", Address = "Bishkek, Manasa 4" };
            Client client5 = new Client() { Id = 5, FirstName = "Clara", LastName = "Chapman", PhoneNumber = "0999556111", Address = "Bishkek, Manasa 5" };
            Client client6 = new Client() { Id = 6, FirstName = "Antonio", LastName = "Washington", PhoneNumber = "0955789054", Address = "Bishkek, Manasa 6" };
            Client client7 = new Client() { Id = 7, FirstName = "Rene", LastName = "Marshal", PhoneNumber = "0990897865", Address = "Bishkek, Manasa 7" };
            Client client8 = new Client() { Id = 8, FirstName = "Janice", LastName = "Fleming", PhoneNumber = "0998990088", Address = "Bishkek, Manasa 8" };
            Client client9 = new Client() { Id = 9, FirstName = "Corey", LastName = "Obrien", PhoneNumber = "0999876432", Address = "Bishkek, Manasa 9" };
            Client client10 = new Client() { Id = 10, FirstName = "Ritthy", LastName = "Spencer", PhoneNumber = "0999675634", Address = "Bishkek, Manasa 10" };
           
            Array array = new[] { client1, client2, client3, client4, client5, client6, client7, client8, client9, client10};

            return View(array);
        }

    }
}
