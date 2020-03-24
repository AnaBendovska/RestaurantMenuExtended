using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class FillModels
    {
        public static int countMeals = FillMeals().Count();
        public static int countIngredients = FillIngredients().Count();
        public static int countAudit = FillAudit().Count();
        public static int countSupplies = FillSupplies().Count();

        public static List<Meal> FillMeals()
        {
            List<Meal> meals = new List<Meal>();

            using (StreamReader r = new StreamReader("Json/Meal.json"))
            {
                string json = r.ReadToEnd();
                meals = JsonConvert.DeserializeObject<List<Meal>>(json);
            }

            return meals;
        }

        public static List<MealType> FillMealTypes()
        {
            List<MealType> t = new List<MealType>();

            using (StreamReader r = new StreamReader("Json/MealType.json"))
            {
                string json = r.ReadToEnd();
                t = JsonConvert.DeserializeObject<List<MealType>>(json);
            }

            return t;
        }

        public static List<Ingredient> FillIngredients()
        {
            List<Ingredient> i = new List<Ingredient>();

            using (StreamReader r = new StreamReader("Json/Ingredients.json"))
            {
                string json = r.ReadToEnd();
                i = JsonConvert.DeserializeObject<List<Ingredient>>(json);
            }

            return i;
        }


        public static List<AuditMealType> FillAudit()
        {
            List<AuditMealType> audits = new List<AuditMealType>();

            using (StreamReader r = new StreamReader("Json/Audit.json"))
            {
                string json = r.ReadToEnd();
                audits = JsonConvert.DeserializeObject<List<AuditMealType>>(json);
            }
            if (audits == null) return new List<AuditMealType>();

            return audits;
        }


        public static List<Supplie> FillSupplies()
        {
            List<Supplie> supplies = new List<Supplie>();

            using (StreamReader r = new StreamReader("Json/Supplies.json"))
            {
                string json = r.ReadToEnd();
                supplies = JsonConvert.DeserializeObject<List<Supplie>>(json);
            }
            if (supplies == null) return new List<Supplie>();

            return supplies;
        }
    }
}
