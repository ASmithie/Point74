using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment
{
    public class Ingredient
    {
        public Ingredient(string code, string description, decimal quantity)
        {
            Code = code;
            Description = description;
            Quantity = quantity;
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
    }
}
