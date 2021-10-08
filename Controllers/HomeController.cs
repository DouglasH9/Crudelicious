using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crudelicious.Models;

namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {

        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // List<Dish> AllDishes = _context.Dishes.ToList();
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            Console.WriteLine(newDish.DishName);
            return RedirectToAction("");
        }

        [HttpGet ("allDishes")]
        public IActionResult AllDishes()
        {
            ViewBag.AllDishes = _context.Dishes.ToList();
            return View();
        }

        [HttpGet ("showone/{id}")]
        public IActionResult ShowOne(int id)
        {
            ViewBag.OneDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            return View();
        }

        [HttpGet ("showone/edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish editedDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            ViewBag.dishEdit = editedDish;
            return View();
        }

        [HttpPost ("/edit")]
        public IActionResult MakeChanges(Dish theDish)
        {
            Console.WriteLine(theDish.DishName);
            Dish dishEdited = _context.Dishes.FirstOrDefault(dish => dish.DishId == theDish.DishId);
            
            dishEdited.DishName = theDish.DishName;
            dishEdited.Tastiness = theDish.Tastiness;
            dishEdited.Calories = theDish.Calories;
            dishEdited.Description = theDish.Description;
            dishEdited.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("ShowOne", new{id = dishEdited.DishId});
        }
        [HttpGet ("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish dishToDelete = _context.Dishes.FirstOrDefault(dish => dish.DishId == id);
            _context.Dishes.Remove(dishToDelete);
            _context.SaveChanges();
            return RedirectToAction("AllDishes");
        }

// ===================!Don't alter anything below here!========================
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
