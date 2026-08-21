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
    }

}
