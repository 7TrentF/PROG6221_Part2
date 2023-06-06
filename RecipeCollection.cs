using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class RecipeCollection
    {
        private List<Recipe> recipes;
        public RecipeCollection()
        {
            recipes = new List<Recipe>();
        }
        public void EnterRecipe()
        {
            Console.WriteLine("\nEnter the name of the recipe:");
            string name = Console.ReadLine();

            Recipe recipe = new Recipe(name);

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                string ingredientName = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of ingredient {i + 1}:");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
                string unit = Console.ReadLine();

                Console.WriteLine($"Enter the number of calories for ingredient {i + 1}:");
                int calories = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the food group for ingredient {i + 1}:");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup);
            
        }

            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string step = Console.ReadLine();

                recipe.AddStep(step);
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe added successfully!");
            Console.WriteLine("Press any key to display the commands");
        }
        public void DisplayRecipeList()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("\nRecipe List:");

            recipes.Sort((r1, r2) => r1.RecipeName.CompareTo(r2.RecipeName));

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.RecipeName);
            }
            Console.WriteLine("Press any key to display the commands");
        }
        public void DisplayRecipe(string recipeName)
        {
            Recipe recipe = recipes.Find(r => r.RecipeName.ToLower() == recipeName.ToLower());
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;
            }

            recipe.DisplayRecipe();
            Console.WriteLine("Press any key to display the commands");
        }
        // Notify the user when a recipe exceeds 300 calories
        public void NotifyUserExceededCalories(string recipeName, int totalCalories)
        {
            Console.WriteLine($"Warning: The recipe '{recipeName}' has exceeded 300 calories. Total calories: {totalCalories}");
        }
    }
}
