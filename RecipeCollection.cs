using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class RecipeCollection
    {
        private List<Recipe> recipes; // Private field to store the list of recipes

        public RecipeCollection()// Constructor to initialize the recipe collection
        {
            recipes = new List<Recipe>(); // Creates an empty list of recipes

            /*Author: Doyle, B. (2016) 
              title of the book: C♯ Programming: From problem analysis to program design.Boston, MA: Cengage Learning. pg 477
              accessed:  2 june 2023
            */
        }

        public void EnterRecipe()
        {
            Console.WriteLine("\nWhat is the name of the recipe:");
            string name = Console.ReadLine(); // Read the name of the recipe from the user

            Recipe recipe = new Recipe(name); // Create a new Recipe object with the entered name
            Delegate d = new Delegate();

            Console.WriteLine("\nEnter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine()); // Read the number of ingredients from the user

            Console.WriteLine("\nEnter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine()); // Read the number of steps from the user


            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nEnter the name of ingredient {i + 1}:");
                string ingredientName = Console.ReadLine(); // Read the name of the ingredient from the user

                Console.WriteLine($"Enter the quantity of ingredient {i + 1}:");
                double quantity = double.Parse(Console.ReadLine()); // Read the quantity of the ingredient from the user

                Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
                string unit = Console.ReadLine(); // Read the unit of measurement for the ingredient from the user

                Console.WriteLine($"Enter the number of calories for ingredient {i + 1}:");
                int calories = int.Parse(Console.ReadLine()); // Read the number of calories for the ingredient from the user
                recipe.CalorieInformation();

                Console.WriteLine($"\nEnter the food group that the ingredient belongs to {i + 1}:");
                recipe.SelectFoodGroup();
                string foodGroup = Console.ReadLine(); // Read the food group for the ingredient from the user

                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup); // Add the ingredient to the recipe
                recipe.OriginalQuantities.Add(quantity);                                   // Store the original quantity in the OriginalQuantities list
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nEnter step {i + 1}:");
                string step = Console.ReadLine(); // Read the description of the step from the user

                recipe.AddStep(step); // Add the step to the recipe
            }

            int totalCalories = recipe.GetTotalCalories();

            if (totalCalories >= 300) // Check if the total calories exceed 300
            {
                d.NotifyUserExceededCalories(recipe.RecipeName, totalCalories);
            }

            recipe.PrintRecipe();    // Calls PrintRecipe method from Recipe class and prints the current recipe to the console.
            recipe.ScaleRecipe();    // Method that scales the recipe. 
            recipe.ResetQuantities();// Method that resets the quantities of all ingredients in the recipe to their original values.
            recipe.ClearRecipe();    // Method that clears the  current recipe. 
            recipes.Add(recipe);     // Method that adds the current recipe to the list of recipes.

            Console.WriteLine("\nRecipe added successfully!");
        }

        public void DisplayRecipeList() // Displays a list of all recipes that the user added.
        {
            if (recipes.Count == 0) // Checks if there are any recipes in the recipes list.
            {
                Console.WriteLine("No recipes found.");
                return; //exits method
            }

            Console.WriteLine("\nRecipe List:"); // Print the heading for the recipe list
            recipes.Sort((r1, r2) => r1.RecipeName.CompareTo(r2.RecipeName));// Sorts the recipes list in alphabetical order by comparing the recipe names using the CompareTo method.

            /*Author: Doyle, B. (2016) 
              title of the book: C♯ Programming: From problem analysis to program design.Boston, MA: Cengage Learning. pg 415-417
              accessed:  02 june 2023

              C#: Sort the elements in the arraylist (2021) GeeksforGeeks. 
              Available at: https://www.geeksforgeeks.org/c-sharp-sort-the-elements-in-the-arraylist/ 
             (Accessed: 02 June 2023). 
              */

            for (int i = 0; i < recipes.Count; i++)  // Display the list of recipes to the user
            {

                Recipe recipe = recipes[i];             // Retrieves recipe at the current index
                Console.WriteLine(recipe.RecipeName);   // Print the name of the recipe
            }
        }


        public void DisplayRecipe(string RecipeName)// Display a specific recipe to the user
        {
            Recipe recipe = recipes.Find(r => r.RecipeName.ToLower() == RecipeName.ToLower());  // Find the recipe with the matching name (case-insensitive)
            /*
             * C#: Array.find() method (2022) GeeksforGeeks.
             * Available at: https://www.geeksforgeeks.org/c-sharp-array-find-method/ 
             * (Accessed: 03 June 2023). 
             */
            if (recipe == null) // Checks if the recipe cannot be found
            {
                Console.WriteLine("Recipe not found.");
                return;//exits method
            }

            recipe.DisplayRecipe(); // Call the DisplayRecipe method of the Recipe class to display the recipe details

        }

    }
}
