using EatAndDrink.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using static EatAndDrink.Controllers.DishController;

namespace EatAndDrink.Controllers
{
    public class DishController : Controller
    {
        public EatAndDrinkDbContext GetContext()
        {
            return new EatAndDrinkDbContext();
        }
        public IActionResult Index()
        {
            return View(GetContext().Dishes.ToList());
        }
        public IActionResult New()
        {
            return View(new DishCreateViewModel());
        }
        public class DishCreateViewModel
        {
            [Required]
            [Display(Name = "Name")]
            public string? Name { get; set; }

            [Required]
            [Display(Name = "Price")]
            public decimal Price { get; set; }
        }
        public async Task<IActionResult>Create(DishCreateViewModel model)
        {
            using (var context = GetContext())
            {
                var dishes = new Dish
                {
                    Name = model.Name, 
                    Price = model.Price,
                };
                context.Dishes.Add(dishes);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            using (var context = GetContext())
            {
                return View(context.Dishes.Find(id));
            }
            //using (var context = GetContext())
            //{
            //    var dishes = context.Dishes.Find(id);
            //    if (dishes == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(dishes);
            //}
        }
        public async Task<IActionResult> Update(Dish model)
        {
            using (var context = GetContext())
            {
                context.Dishes.Update(model);
                context.SaveChanges();
            }
            return RedirectToAction("Index");

            //if (model == null)
            //{
            //    return BadRequest();
            //}
            //using (var context = GetContext())
            //{
            //    context.Dishes.Update(model);
            //    context.SaveChanges();
            //}
            //return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            using (var context = GetContext())
            {
                var dishes = context.Dishes.Find(id);
                context.Dishes.Remove(dishes);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
            //using (var context = GetContext())
            //{
            //    var dishes = context.Dishes.Find(id);
            //    if (dishes == null)
            //    {
            //        return NotFound();
            //    }
            //    context.Dishes.Remove(dishes);
            //    context.SaveChanges();
            //}
            //return RedirectToAction("Index");
        }
    }
}

