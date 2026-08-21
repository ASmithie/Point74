using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment
{
    public class Ingredient
    {
        public Ingredient(string code, string description, decimal quantity, IEnumerable<Allergen> allergens = null)
        {
            Code = code;
            Description = description;
            Quantity = quantity;
            Allergens = allergens ?? Enumerable.Empty<Allergen>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public IEnumerable<Allergen> Allergens { get; set; }= Enumerable.Empty<Allergen>();
    }
}
