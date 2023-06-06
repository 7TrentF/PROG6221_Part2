using PROG6221_Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Recipe
    {
        public string RecipeName { get; set; }  // Name of the recipe
        public List<Ingredient> Ingredients { get; set; }  // List of ingredients in the recipe
        public List<string> Steps { get; set; }  // List of steps to prepare the recipe
        public List<double> OriginalQuantities { get; set; } //public double array to store the original quantities of each ingredient
       
        public Recipe(string name) // Constructor for the Recipe class
        {                          // Initializes a new instance of the Recipe class with the specified name

            RecipeName = name;// Set the RecipeName property to the provided name 
            Ingredients = new List<Ingredient>();  // Create a new empty list to store the ingredients of the recipe
            Steps = new List<string>();  // Create a new empty list to store the steps of the recipe
            OriginalQuantities = new List<double>(); // Create a new empty list to store the recipes OriginalQueantities 

            // Loop through the OriginalQuantities list and assign default values
            for (int i = 0; i < Ingredients.Count; i++)
            {
                OriginalQuantities[i] = 0.0;
            }
            /*
    Author: Doyle, B. (2016) 
    title of the book: C♯ Programming: From problem analysis to program design. Boston, MA: Cengage Learning. pg 475-484
    accessed:  31 may 2023
    */
        }

        public void AddIngredient(string name, double quantity, string unit, int calories, string foodGroup)// Method that adds a new ingredient to the Ingredients array at the specified index
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit, Calories = calories, FoodGroup = foodGroup }); // adds a new Ingredient object to the Ingredients list and assigns values to the corresponding variables

        }

        public void AddStep(string step)// Method that adds a new step to the Steps array at the specified index
        {
            Steps.Add(step); // Assigns the specified description string to the specified index in the Steps array
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe for: {RecipeName}");
            Console.WriteLine("Ingredients:");

            // Iterate over each ingredient in the Ingredients list
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredient ingredient = Ingredients[i]; // Retrieves the ingredient at the current index
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}"); // Display the name, quantity, and unit of the ingredient
                Console.WriteLine($"Calories: {ingredient.Calories}");  // Display the calories of the ingredient
                Console.WriteLine($"Food Group: {ingredient.FoodGroup}");// Display the food group of the ingredient
                Console.WriteLine($"Total Calories: {GetTotalCalories()}");// Display the total calories of the recipe
            }

            Console.WriteLine("\nSteps:");

            
            for (int i = 0; i < Steps.Count; i++) // Iterate over each step in the Steps list
            {
                
                Console.WriteLine($"{i + 1}. {Steps[i]}");// Display the step number and description
            }
        }
        
        
            // Calculates and returns the total calories of all the ingredients in the recipe
            public int GetTotalCalories()
            {
                int totalCalories = 0;

                // Iterate over each ingredient in the Ingredients list
                for (int i = 0; i < Ingredients.Count; i++)
                {
                    // Retrieve the current ingredient at the index
                    Ingredient ingredient = Ingredients[i];

                    // Add the calories of the current ingredient to the total
                    totalCalories += ingredient.Calories;
                }

                // Return the total calories
                return totalCalories;
            }

        public void ScaleRecipe()
        {
            Console.WriteLine("\nDo you want to scale the recipe? (y/n)");
            string answer = Console.ReadLine().ToLower(); // Asks the user if they want to scale the recipe and reads their response.

            if (answer == "y")
            {
                Console.WriteLine("Enter the scaling factor: " +
                                  "\n0.5 (Half) \n  2 (Double, or \n  3 (Triple): \n"); // Asks the user to enter a scaling factor.

                double factor = double.Parse(Console.ReadLine()); // Reads the user's input and parses it as a double.


                if (factor == 0.5) // If the factor is 0.5, multiply by 0.5 instead of the input factor
                {

                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        Ingredient ingredient = Ingredients[i];              
                        ingredient.Quantity *= 0.5;
                    }
                }
                else if (factor == 2) // If the scaling factor is 2 (double)
                {
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        Ingredients[i].Quantity = OriginalQuantities[i] * 2; // Double the quantity of each ingredient
                    }
                }
                else if (factor == 3) // If the scaling factor is 3 (triple)
                {
                    for (int i = 0; i < Ingredients.Count; i++)
                    {
                        Ingredients[i].Quantity = OriginalQuantities[i] * 3; // Triple the quantity of each ingredient
                    }
                    /*John S
                      https://stackoverflow.com/questions/2675196/c-sharp-method-to-scale-values
                      accessed: 24 april 2023
                    */
                }
            }

            Console.WriteLine("\nScaled Recipe:");
            PrintRecipe(); // Prints the scaled recipe to the console.
        }

        public void PrintRecipe()// Method that prints the recipe to the console
        {
            Console.WriteLine("\n---------------------------------------" +
                                $"\nRecipe Name: {RecipeName}\n" +
                                "---------------------------------------");

            Console.WriteLine("\nIngredients:");

            for (int i = 0; i < Ingredients.Count; i++)  // Iterate over each ingredient in the Ingredients list using a for loop
            {
                Ingredient ingredient = Ingredients[i]; // Retrieve the current ingredient at the index
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:"); // Display the steps of the recipe

            for (int i = 0; i < Steps.Count; i++) // Iterate over each step in the Steps list using a for loop
            {
                string step = Steps[i]; // Retrieve the current step at the index
                Console.WriteLine($"{i + 1}. {step}"); // Display the step number and its description
            }

        }
        public void ResetQuantities()
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].Quantity = OriginalQuantities[i]; // Reset the quantity of each ingredient to its original value
            }
        }
       
        public void ClearRecipe() // Clear the recipe by resetting its properties and clearing the lists
        {
            RecipeName = string.Empty;// Reset the recipe name to an empty string
            Ingredients.Clear(); // Clear the Ingredients list, removing all elements
            Steps.Clear(); // Clear the Steps list, removing all elements
            OriginalQuantities.Clear(); // Clear the OriginalQuantities list, removing all elements
        }

    }
}






