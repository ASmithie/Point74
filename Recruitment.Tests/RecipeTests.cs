using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void Recipe_ShouldCorrectlyReturnDescription()
        {
            Recipe recipe = RecipeTestData.GetVegetableSoupRecipe();

            Assert.That(recipe.Description, Is.EqualTo("Vegetable Soup"));
        }

        [Test]
        [TestCase(100, ExpectedResult = 0)]
        [TestCase(75, ExpectedResult = 25)]
        [TestCase(0, ExpectedResult = 100)]
        [TestCase(33.33, ExpectedResult = 67)]
        [TestCase(200, ExpectedResult = -100)]
        public decimal Recipe_ShouldCorrectlyCalculateCookLoss(decimal cookedWeight)
        {
            IRecipe recipe = (IRecipe)RecipeTestData.GetBeefPieRecipe();
            recipe.CookedWeight = cookedWeight;
            return recipe.CookLoss;
        }

        private static IEnumerable<TestCaseData> TotalWeightCases()
        {
            yield return new TestCaseData(RecipeTestData.GetBeefPieRecipe()).Returns(100);
            yield return new TestCaseData(RecipeTestData.GetVegetableSoupRecipe()).Returns(160);
        }

        [Test]
        [TestCaseSource(nameof(TotalWeightCases))]
        public decimal Recipe_ShouldCorrectlyCalculateTotalWeight(IRecipe recipe)
        {
            return recipe.TotalWeight;
        }

        [Test]
        public void Ingredient_ShouldSupportMultipleAllergens()
        {
            Ingredient ingredient = IngredientTestData.GetPrawnMayoIngredient(50);

            Assert.That(ingredient.Allergens, Is.EquivalentTo(new[] { Allergen.Fish, Allergen.Egg }));
        }

        [Test]
        public void Recipe_ShouldListAllAllergensAcrossIngredients()
        {
            Recipe recipe = RecipeTestData.GetFishAndChipsRecipe();

            Assert.That(recipe.Allergens, Is.EquivalentTo(new[] { Allergen.Fish, Allergen.Egg, Allergen.Milk }));
        }

        [Test]
        public void Recipe_AllergensShouldNotContainDuplicates()
        {
            Recipe recipe = RecipeTestData.GetPrawnCocktailRecipe();

            Assert.That(recipe.Allergens, Is.EquivalentTo(new[] { Allergen.Fish, Allergen.Egg }));
        }

        [Test]
        public void Recipe_ShouldHaveNoAllergensWhenIngredientsHaveNone()
        {
            Recipe recipe = RecipeTestData.GetBeefPieRecipe();

            Assert.That(recipe.Allergens, Is.Empty);
        }

    }

}
