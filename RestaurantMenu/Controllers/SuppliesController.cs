using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Models;

namespace RestaurantMenu.Controllers
{
    public class SuppliesController : Controller
    {
        public IActionResult Index()
        {
            SupplieIndex supplies = new SupplieIndex();
            supplies.supplies = FillModels.FillSupplies();

            return View(supplies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(Supplie s)
        {
            foreach(Ingredient i in FillModels.FillIngredients())
            {
                if (s.Ingredient.Equals(i.Name))
                {
                    s.I = i;
                    break;
                }
            }
            s.Ingredient = null;
            if (ModelState.IsValid)
            {
                s.AddToFile(s);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteItem(string id)
        {
            Supplie pom = new Supplie();
            foreach (Supplie s in FillModels.FillSupplies())
            {
                if(s.Id.ToString() == id)
                {
                    pom = s;
                }
            }
            pom.RemoveFromFile(pom);
            return View();
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            DeleteItem(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id, string ingredient)
        {
            List<Supplie> supplies = FillModels.FillSupplies();
            foreach(Supplie s in supplies)
            {
                if (s.Id.ToString().Equals(id))
                {
                    return View(s);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Supplie s)
        {
            foreach (Ingredient i in FillModels.FillIngredients())
            {
                if (s.Ingredient.Equals(i.Name))
                {
                    s.I = i;
                    break;
                }
            }
            s.Ingredient = null;
            if (ModelState.IsValid)
            {
                s.EditToFile(s);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}