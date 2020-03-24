using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class Supplie
    {
        private int _id;
        private Ingredient _i;
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        private int _quantity;
        [Required]
        private string _dateExpire;

        [Required]
        private string _ingredient;

        public int Id { get => _id; set => _id = value; }
        public Ingredient I { get => _i; set => _i = value; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get => _quantity; set => _quantity = value; }
        [Required]
        public string DateExpire { get => _dateExpire; set => _dateExpire = value; }
        [Required]
        public string Ingredient { get => _ingredient; set => _ingredient = value; }

        public Supplie() { }

        public Supplie(int id, Ingredient i, int quantity, string dateExpire)
        {
            _id = id;
            _i = i;
            _quantity = quantity;
            _dateExpire = dateExpire;
        }

        public void AddToFile(Supplie s)
        {
            List<Supplie> supplies = FillModels.FillSupplies();
            FillModels.countSupplies += 1;
            supplies.Add(s);
            string json = JsonConvert.SerializeObject(supplies, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Supplies.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, supplies);
            }
        }

        public void RemoveFromFile(Supplie s)
        {
            List<Supplie> supplies = FillModels.FillSupplies();
            FillModels.countSupplies -= 1;
            foreach (Supplie p in supplies)
            {
                if (p.Id.Equals(s.Id))
                {
                    s = p;
                }
            }
            supplies.Remove(s);
            string json = JsonConvert.SerializeObject(supplies, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Supplies.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, supplies);
            }
        }

        public void EditToFile(Supplie s)
        {
            List<Supplie> supplies = FillModels.FillSupplies();
            foreach(Supplie p in supplies)
            {
                if (p.Id.Equals(s.Id))
                {
                    p.Quantity = s.Quantity;
                    p.DateExpire = s.DateExpire;
                    break;
                }
            }
            string json = JsonConvert.SerializeObject(supplies, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Supplies.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, supplies);
            }
        }
    }
}
