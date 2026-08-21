using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment
{
    public interface IRecipe
    {
        /// <summary>
        /// The code of the recipe.
        /// </summary>
        string Code { get; }

        /// <summary>
        /// The description of the recipe.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The total weight of the recipe, which is the sum of all ingredient quantities.
        /// </summary>
        decimal TotalWeight { get; }

        /// <summary>
        /// The weight of the recipe after it's cooked.
        /// </summary>
        decimal CookedWeight { get; set; }

        /// <summary>
        /// The amount of the recipe's total weight that is lost while cooking. This is calculated by finding the percentage of the weight that's lost between the total weight
        /// and the cooked weight of the recipe. For example:
        ///  - If the total weight of the recipe is 100g and the cooked weight is 50g, then the cook loss is 50%
        ///  - If the total weight of the recipe is 100g and the cooked weight is 75g, then the cook loss is 25%
        ///  - If the total weight of the recipe is 200g and the cooked weight is 150g, then the cook loss is 25%.
        ///  The value should be returned as a percentage of the total weight, and should be whole number and not a fractional decimal. e.g. 100 instead of 1.
        /// </summary>
        decimal CookLoss { get; }
        
        /// <summary>
        /// Gets the list of all allergens present in the recipe's ingredients.
        /// </summary>
        IEnumerable<Allergen> Allergens { get; }

        /// <summary>
        /// Gets a string that lists all the ingredients in the recipe, ordered by quantity (largest first), and includes any allergens present in each ingredient.
        /// </summary>
        string IngredientDeclaration { get; }
    }
}
