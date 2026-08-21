using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Tests
{
    public static class IngredientTestData
    {
        public static Ingredient GetBeefIngredient(decimal quantity)
        {
            return new Ingredient("M01", "Beef", quantity);
        }

        public static Ingredient GetPastryIngredient(decimal quantity)
        {
            return new Ingredient("I01", "Pastry", quantity);
        }

        public static Ingredient GetGravyIngredient(decimal quantity)
        {
            return new Ingredient("M02", "Gravy", quantity);
        }

        public static Ingredient GetCarrotIngredient(decimal quantity)
        {
            return new Ingredient("I02", "Carrot", quantity);
        }

        public static Ingredient GetMushroomIngredient(decimal quantity)
        {
            return new Ingredient("I03", "Mushroom", quantity);
        }

        public static Ingredient GetBeansIngredient(decimal quantity)
        {
            return new Ingredient("I04", "Beans", quantity);
        }

        public static Ingredient GetOnionIngredient(decimal quantity)
        {
            return new Ingredient("I05", "Onion", quantity);
        }

        public static Ingredient GetVegetableStockIngredient(decimal quantity)
        {
            return new Ingredient("I06", "Vegetable Stock", quantity);
        }

        public static Ingredient GetFlourIngredient(decimal quantity)
        {
            return new Ingredient("I07", "Flour", quantity);
        }

        public static Ingredient GetEggsIngredient(decimal quantity)
        {
            return new Ingredient("I08", "Eggs", quantity);
        }

        public static Ingredient GetMilkIngredient(decimal quantity)
        {
            return new Ingredient("I09", "Milk", quantity);
        }
    }
}
