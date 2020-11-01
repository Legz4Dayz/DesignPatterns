using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost: " + vegMeal.getCost());

            Meal chickenMeal = mealBuilder.prepareChickenMeal();
            Console.WriteLine("Chicken Meal");
            chickenMeal.showItems();
            Console.WriteLine("Total Cost: " + chickenMeal.getCost());
        }
    }
}
