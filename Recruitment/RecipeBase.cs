using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment
{
    public abstract class RecipeBase
    {
        public RecipeBase(string code, string description)
        {
            Code = code;
            Description = description;
            Ingredients = new List<Ingredient>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }

        /// <summary>
        /// Returns the sum of all the ingredient quantities.
        /// </summary>
        public abstract decimal TotalWeight { get; }

        /// <summary>
        /// The weight of the recipe after it's cooked.
        /// </summary>
        public decimal CookedWeight { get; set; }
    }
}
