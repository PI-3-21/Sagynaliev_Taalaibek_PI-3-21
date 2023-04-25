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
            //using (var context = GetContext())
            //{
            //	return View(context.Clients.Find(id));
            //}
            using (var context = GetContext())
            {
                var client = context.Clients.Find(id);
                if (client == null)
                {
                    return NotFound();
                }
                return View(client);
            }
        }
		public async Task<IActionResult> Update(Client model)
		{
            //using (var context = GetContext())
            //{
            //	context.Clients.Update(model);
            //	context.SaveChanges();
            //}
            //return RedirectToAction("Index");
            if (model == null)
            {
                return BadRequest();
            }
            using (var context = GetContext())
            {
                context.Clients.Update(model);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

		public async Task<IActionResult> Delete(int id)
		{
            //using (var context = GetContext())
            //{
            //	var clients = context.Clients.Find(id);
            //	context.Clients.Remove(clients);
            //	context.SaveChanges();
            //}
            //return RedirectToAction("Index");
            using (var context = GetContext())
            {
                var client = context.Clients.Find(id);
                if (client == null)
                {
                    return NotFound();
                }
                context.Clients.Remove(client);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
	}
}
