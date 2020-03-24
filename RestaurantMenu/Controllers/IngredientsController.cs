using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Models;

namespace RestaurantMenu.Controllers
{
    public class IngredientsController : Controller
    {
        public IActionResult Index()
        {
            List<Ingredient> ingredients = FillModels.FillIngredients();

            return View(ingredients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(Ingredient i)
        {
            if (ModelState.IsValid)
            {
                i.AddToFile(i);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteItem(string id)
        {
            foreach (Ingredient i in FillModels.FillIngredients())
            {
                if (i.Id.ToString().Equals(id))
                {
                    i.RemoveFromFile(i);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            DeleteItem(id);
            return RedirectToAction("Index");
        }
    }
}