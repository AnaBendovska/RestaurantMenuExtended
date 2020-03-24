using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantMenu.Models;

namespace RestaurantMenu.Controllers
{
    public class MenuController : Controller
    {
        [AuditActionFilter]
        public IActionResult Meal(string type = "")
        {
            List<Meal> meals = FillModels.FillMeals();
            if (!string.IsNullOrEmpty(type))
            {
                List<Meal> pom = new List<Meal>();
                foreach (Meal m in meals)
                {
                    if (RestaurantMenu.Models.MealType.GetTypeOfMeal((int)m.MealTypeId).ToLower().Equals(type))
                    {
                        pom.Add(m);
                    }
                }

                meals = pom;
            }

            return View(meals);
        }

        public IActionResult Create()
        {
            return View();
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult Create(Meal m)
        {
            m.Ingredients = new List<Ingredient>();
            if (ModelState.IsValid)
            {
                if (m.MealTypeId == 7 && m.Price < 200)
                {
                    ModelState.AddModelError("Price", "Price for Dessert should be at least 200.");
                    return View();
                }
                List<Ingredient> ingredients = FillModels.FillIngredients();
                foreach (Ingredient i in ingredients)
                {
                    foreach (string s in m.IList)
                    {
                        if (i.Name == s)
                        {
                            m.Ingredients.Add(i);
                            break;
                        }
                    }
                }
                m.IList = null;
                m.AddToFile(m);
                return RedirectToAction("Meal");
            }

            return View();
        }

        public IActionResult Interests(string type)
        {
            List<AuditMealType> interests = FillModels.FillAudit();
            if (!string.IsNullOrEmpty(type))
            {
                List<AuditMealType> pom = new List<AuditMealType>();
                foreach (AuditMealType a in interests)
                {
                    if (a.MealType.ToLower().Equals(type))
                    {
                        pom.Add(a);
                    }
                }

                interests = pom;
            }
            return View(interests);
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteItem(string id)
        {
            foreach(Meal m in FillModels.FillMeals())
            {
                if (m.Name.Equals(id))
                {
                    m.RemoveFromFile(m);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            DeleteItem(id);
            return RedirectToAction("Meal");
        }

    }
}