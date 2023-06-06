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
        }

        /*Author: Doyle, B. (2016) 
          title of the book: C♯ Programming: From problem analysis to program design.Boston, MA: Cengage Learning. pg 477
          accessed:  2 june 2023
          */


        // Delegate declaration for notifying the user about recipe calories
        public delegate void NotifyUserDelegate(string recipeName, int totalCalories);
        /*Author: Doyle, B. (2016) 
            title of the book: C♯ Programming: From problem analysis to program design.Boston, MA: Cengage Learning. pg 686-690
            accessed:  6 june 2023
        */

        public void HandleCalorieExceeded(string recipeName, int totalCalories)
        {
            Console.WriteLine($"Warning: The recipe '{recipeName}' has exceeded 300 calories. Total calories: {totalCalories}");
        }

        public void EnterRecipe()
        {
            Console.WriteLine("\nEnter the name of the recipe:");
            string name = Console.ReadLine(); // Read the name of the recipe from the user

            Recipe recipe = new Recipe(name); // Create a new Recipe object with the entered name

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine()); // Read the number of ingredients from the user

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

               
                recipe.SetNotifyUserHandler(HandleCalorieExceeded); // Set the notification handler for calorie exceedance

                Console.WriteLine($"Enter the food group for ingredient {i + 1}:");
                string foodGroup = Console.ReadLine(); // Read the food group for the ingredient from the user

                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup); // Add the ingredient to the recipe
            }


            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine()); // Read the number of steps from the user

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string step = Console.ReadLine(); // Read the description of the step from the user

                recipe.AddStep(step); // Add the step to the recipe
            }

            recipe.ScaleRecipe(); //scale method


            recipes.Add(recipe); // Add the recipe to the list of recipes
            Console.WriteLine("Recipe added successfully!");

        

        // Check if the total calories exceed 300
        int totalCalories = recipe.GetTotalCalories(); // Calculate the total calories of the recipe

            //if (totalCalories > 300)
           // {
                //NotifyUserDelegate(recipe.RecipeName, totalCalories); // Notify the user if the total calories exceed 300
            //}
        }

        

        // Display the list of recipes to the user
        public void DisplayRecipeList()
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


            // Display the list of recipes to the user
            for (int i = 0; i < recipes.Count; i++)
            {
                // Retrieves recipe at the current index
                Recipe recipe = recipes[i];

                // Print the name of the recipe
                Console.WriteLine(recipe.RecipeName);
            }

            Console.WriteLine("Press any key to display the commands");
        }
        
        public void DisplayRecipe(string RecipeName)// Display a specific recipe to the user
        {
            // Find the recipe with the matching name (case-insensitive)
            Recipe recipe = recipes.Find(r => r.RecipeName.ToLower() == RecipeName.ToLower());
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
            Console.WriteLine("Press any key to display the commands");
        } 
        public void NotifyUserExceededCalories(string recipeName, int totalCalories)// Notify the user when a recipe exceeds 300 calories
        {
            Console.WriteLine($"Warning: The recipe '{recipeName}' has exceeded 300 calories. Total calories: {totalCalories}");
        }
    }
}
