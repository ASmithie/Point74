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

        public IEnumerable<Allergen> Allergens => Ingredients.SelectMany(i => i.Allergens).Distinct();

        public string IngredientDeclaration => string.Join(", ", Ingredients.OrderByDescending(i => i.Quantity).Select(FormatIngredient));

        private static string FormatIngredient(Ingredient ingredient)
        {
            if (!ingredient.Allergens.Any())
                return ingredient.Description;

            string allergenList = string.Join(", ", ingredient.Allergens);
            return $"{ingredient.Description} (<b>{allergenList}</b>)";
        }
    }
}
