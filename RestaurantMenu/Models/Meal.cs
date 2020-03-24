using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class Meal
    {
        [Required(ErrorMessage = "Name is a required field.")]
        [MaxLength(150)]
        private string _name;
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        private double _price;
        private List<Ingredient> _ingredients;
        [Required]
        [Range(1, 7, ErrorMessage = "Select meal Type.")]
        private int _mealTypeId;

        private bool _isVegeterian;

        [Required(ErrorMessage = "Ingredients is a required field.")]
        private List<string> iList;

        [Required]
        [MaxLength(150)]
        public string Name { get => _name; set => _name = value; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double Price { get => _price; set => _price = value; }
        public List<Ingredient> Ingredients { get => _ingredients; set => _ingredients = value; }
        [Required]
        [Range(1, 7, ErrorMessage = "Select meal Type.")]
        public int MealTypeId { get => _mealTypeId; set => _mealTypeId = value; }
        public bool IsVegeterian { get => _isVegeterian; set => _isVegeterian = value; }

        [Required(ErrorMessage = "Ingredients is a required field.")]
        public List<string> IList { get => iList; set => iList = value; }

        public Meal() { }
        public Meal(string name, double price, List<Ingredient> ingredients, MealType mealType, bool isVegeterian)
        {
            _name = name;
            _price = price;
            _ingredients = ingredients;
            _mealTypeId = (int)mealType.Type;
            _isVegeterian = isVegeterian;
        }

        public void AddToFile(Meal m)
        {
            List<Meal> meals = FillModels.FillMeals();
            FillModels.countMeals += 1;
            meals.Add(m);
            string json = JsonConvert.SerializeObject(meals, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Meal.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, meals);
            }
        }

        public void RemoveFromFile(Meal m)
        {
            List<Meal> meals = FillModels.FillMeals();
            foreach(Meal p in meals)
            {
                if (p.Name.Equals(m.Name))
                {
                    m = p;
                }
            }
            FillModels.countMeals -= 1;
            meals.Remove(m);
            string json = JsonConvert.SerializeObject(meals, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Meal.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, meals);
            }
        }
    }
}
