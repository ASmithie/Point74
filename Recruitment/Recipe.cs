using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment
{
    public class Recipe : RecipeBase, IRecipe
    {
        public Recipe(string code, string description)
            :base(code, description) { }

        public override decimal TotalWeight => Ingredients.Sum(i => i.Quantity);

        public decimal CookLoss => Math.Round((TotalWeight - CookedWeight) / TotalWeight * 100);
    }
}
