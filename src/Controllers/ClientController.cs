using EatAndDrink.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EatAndDrink.Controllers
{
    public class ClientController : Controller
    {
        public EatAndDrinkDbContext GetContext()
        {
            return new EatAndDrinkDbContext();
        }

        public IActionResult Index()
        {
            //Client client1 = new Client() { Id = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "0702350302", Address = "Bishkek, Manasa 1" };
            //Client client2 = new Client() { Id = 2, FirstName = "Ivan", LastName = "Ivanov", PhoneNumber = "0225601100", Address = "Bishkek, Manasa 2" };
            //Client client3 = new Client() { Id = 3, FirstName = "Sergio", LastName = "Olson", PhoneNumber = "0505601100", Address = "Bishkek, Manasa 3" };
            //Client client4 = new Client() { Id = 4, FirstName = "Ritthy", LastName = "Adams", PhoneNumber = "0559091010", Address = "Bishkek, Manasa 4" };
            //Client client5 = new Client() { Id = 5, FirstName = "Clara", LastName = "Chapman", PhoneNumber = "0999556111", Address = "Bishkek, Manasa 5" };
            //Client client6 = new Client() { Id = 6, FirstName = "Antonio", LastName = "Washington", PhoneNumber = "0955789054", Address = "Bishkek, Manasa 6" };
            //Client client7 = new Client() { Id = 7, FirstName = "Rene", LastName = "Marshal", PhoneNumber = "0990897865", Address = "Bishkek, Manasa 7" };
            //Client client8 = new Client() { Id = 8, FirstName = "Janice", LastName = "Fleming", PhoneNumber = "0998990088", Address = "Bishkek, Manasa 8" };
            //Client client9 = new Client() { Id = 9, FirstName = "Corey", LastName = "Obrien", PhoneNumber = "0999876432", Address = "Bishkek, Manasa 9" };
            //Client client10 = new Client() { Id = 10, FirstName = "Ritthy", LastName = "Spencer", PhoneNumber = "0999675634", Address = "Bishkek, Manasa 10" };

            return View(GetContext().Clients.ToList());
        }

        public IActionResult New()
        {
            return View(new ClientCreateViewModel());
        }

        public class ClientCreateViewModel
        {
            [Required]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Required]
            [Display(Name = "Address")]
            public string Address { get; set; }
        }

        public async Task<IActionResult>Create(ClientCreateViewModel model)
        {
            using (var context = GetContext())
            {
                var client = new Client
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address,
                };
                context.Clients.Add(client);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
			using (var context = GetContext())
			{
				return View(context.Clients.Find(id));
			}
		}
		public async Task<IActionResult> Update(Client model)
		{
			using (var context = GetContext())
			{
				context.Clients.Update(model);
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			using (var context = GetContext())
			{
				var clients = context.Clients.Find(id);
				context.Clients.Remove(clients);
				context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
