using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class MealType
    {
        private int _id;
        private TypeOfMeal _type;
        private bool _isActive;

        public int Id { get => _id; set => _id = value; }
        public TypeOfMeal Type { get => _type; set => _type = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        public enum TypeOfMeal
        {
            Breakfast,
            Lunch,
            Pasta,
            Salad,
            Fish,
            Soup,
            Dessert
        }

        public MealType(TypeOfMeal type, bool isActive)
        {
            _id = (int) type;
            _type = (TypeOfMeal) _id;
            _isActive = isActive;
        }

        public static string GetTypeOfMeal(int i)
        {
            switch (i)
            {
                case 1: return "Breakfast";
                case 2: return "Lunch";
                case 3: return "Pasta";
                case 4: return "Salad";
                case 5: return "Fish";
                case 6: return "Soup";
                case 7: return "Dessert";
                default: return "";
            }
        }

        public static List<MealType> ListAllActiveTypes()
        {
            List<MealType> types = new List<MealType>();

            using (StreamReader r = new StreamReader("Json/MealType.json"))
            {
                string json = r.ReadToEnd();
                types = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MealType>>(json);
            }

            return types;
        }
    }
}
