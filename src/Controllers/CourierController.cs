using EatAndDrink.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EatAndDrink.Controllers
{
    public class CourierController : Controller
    {
        public EatAndDrinkDbContext GetContext()
        {
            return new EatAndDrinkDbContext();
        }
        public IActionResult Index()
        {
            return View(GetContext().Couriers.ToList());
        }
        public IActionResult New()
        {
            return View(new CourierCreateViewModel());
        }

        public class CourierCreateViewModel
        {
            [Required]
            [Display(Name = "First name")]
            public string? FirstName { get; set; }

            [Required]
            [Display(Name = "Last name")]
            public string? LastName { get; set; }

            [Required]
            [Display(Name = "Phone number")]
            public string? PhoneNumber { get; set; }

        }

        public async Task<IActionResult>Create(CourierCreateViewModel model)
        {
            using (var context = GetContext())
            {
                var courier = new Courier
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                };
                context.Couriers.Add(courier);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            using (var context = GetContext())
            {
                return View(context.Couriers.Find(id));
            }
        }
        public async Task<IActionResult> Update(Courier model)
        {
            using (var context = GetContext())
            {
                context.Couriers.Update(model);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            using (var context = GetContext())
            {
                var couriers = context.Couriers.Find(id);
                context.Couriers.Remove(couriers);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

