using Grpc.Core;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class AuditMealType
    {
        private int _id;
        private string _mealType;
        private DateTime _time;

        public int Id { get => _id; set => _id = value; }
        public string MealType { get => _mealType; set => _mealType = value; }
        public DateTime Time { get => _time; set => _time = value; }

        public AuditMealType(int id, string mealType, DateTime time)
        {
            _id = id;
            _mealType = mealType;
            _time = time;
        }

        public static void AddToFile(string type)
        {
            List<AuditMealType> a = FillModels.FillAudit();
            FillModels.countAudit += 1;
            a.Add(new AuditMealType(FillModels.countAudit, type.First().ToString().ToUpper()+type.Substring(1), DateTime.Now));
            string json = JsonConvert.SerializeObject(a, Formatting.Indented);

            using (StreamWriter file = File.CreateText("Json/Audit.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, a);
            }
        }
    }
}
