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

        #region task1 tests
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
        #endregion

        #region task2 tests
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
        #endregion

        #region task3 tests
        [Test]
        public void Recipe_IngredientDeclaration_ShouldOrderByDescendingQuantityWithNoAllergens()
        {
            Recipe recipe = RecipeTestData.GetBeefPieRecipe();

            Assert.That(recipe.IngredientDeclaration, Is.EqualTo("Pastry, Beef, Gravy"));
        }

        [Test]
        public void Recipe_IngredientDeclaration_ShouldBoldAllergensInParentheses()
        {
            Recipe recipe = RecipeTestData.GetFishAndChipsRecipe();

            Assert.That(recipe.IngredientDeclaration, Is.EqualTo("Fish (<b>Fish</b>), Milk (<b>Milk</b>), Eggs (<b>Egg</b>)"));
        }

        [Test]
        public void Recipe_IngredientDeclaration_ShouldGroupMultipleAllergensForOneIngredient()
        {
            Recipe recipe = RecipeTestData.GetPrawnCocktailRecipe();

            Assert.That(recipe.IngredientDeclaration, Is.EqualTo("Fish (<b>Fish</b>), Prawn Mayo (<b>Fish, Egg</b>)"));
        }

        [Test]
        public void Recipe_IngredientDeclaration_ShouldBeEmptyWhenNoIngredients()
        {
            Recipe recipe = new Recipe("R999", "Empty Recipe");

            Assert.That(recipe.IngredientDeclaration, Is.Empty);
        }
        #endregion
    }

}
