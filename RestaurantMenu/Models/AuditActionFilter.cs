using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class AuditActionFilter : ActionFilterAttribute
    {
        private string _type;

        public string Type { get => _type; set => _type = value; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionArguments.ContainsKey("type"))
            {
                AuditMealType.AddToFile((string)filterContext.ActionArguments["type"]);
            }
        }
    }
}
