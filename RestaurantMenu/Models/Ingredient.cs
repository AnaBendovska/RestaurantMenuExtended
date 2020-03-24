using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class Ingredient
    {
        private int _id;
        [Required]
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Ingredient() { }
        public Ingredient(int id, string name)
        {
            Id = id;
            _name = name;
        }

        public static List<string> GetIng()
        {
            List<string> list = new List<string>();
            foreach(Ingredient i in FillModels.FillIngredients())
            {
                list.Add(i.Name);
            }
            return list;
        }

        public void AddToFile(Ingredient i)
        {
            List<Ingredient> ingredients = FillModels.FillIngredients();
            FillModels.countIngredients += 1;
            ingredients.Add(i);
            string json = JsonConvert.SerializeObject(ingredients, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Ingredients.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, ingredients);
            }
        }

        public void RemoveFromFile(Ingredient i)
        {
            List<Ingredient> ingredients = FillModels.FillIngredients();
            FillModels.countIngredients -= 1;
            foreach (Ingredient p in ingredients)
            {
                if (p.Id.Equals(i.Id))
                {
                    i = p;
                }
            }
            ingredients.Remove(i);
            string json = JsonConvert.SerializeObject(ingredients, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Ingredients.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, ingredients);
            }
        }
    }
}
