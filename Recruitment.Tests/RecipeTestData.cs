using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Tests
{
    public static class RecipeTestData
    {
        public static Recipe GetBeefPieRecipe()
        {
            Recipe recipe = new Recipe("R001", "Beef Pie");

            recipe.Ingredients = new Ingredient[]
            {
                IngredientTestData.GetPastryIngredient(50),
                IngredientTestData.GetBeefIngredient(25),
                IngredientTestData.GetGravyIngredient(25)
            };

            return recipe;
        }

        public static Recipe GetVegetableSoupRecipe()
        {
            Recipe recipe = new Recipe("R002", "Vegetable Soup");

            recipe.Ingredients = new Ingredient[]
            {
                IngredientTestData.GetCarrotIngredient(20),
                IngredientTestData.GetMushroomIngredient(20),
                IngredientTestData.GetBeansIngredient(20),
                IngredientTestData.GetOnionIngredient(20),
                IngredientTestData.GetVegetableStockIngredient(80)
            };

            return recipe;
        }


        public static Recipe GetPancakeRecipe()
        {
            Recipe recipe = new Recipe("R003", "Pancake");

            recipe.Ingredients = new Ingredient[]
            {
                IngredientTestData.GetFlourIngredient(100),
                IngredientTestData.GetEggsIngredient(40),
                IngredientTestData.GetMilkIngredient(60),
            };

            return recipe;
        }
    }
}
