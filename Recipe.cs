using PROG6221_Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Recipe
    {

        public string RecipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        //get and set modifyers allow the variable to be read and modified from outside the class.
        //public array to store the ingredients of the recipe
        //get and set modifyers allow the variable to be read and modified from outside the class.
        public List<string> Steps { get; set; } //public integer variable to store the number of steps for the recipe 
                                                //get and set modifyers allow the variable to be read and modified from outside the class.
                                                //public stirng array to store the description of the steps for the recipe.
                                                //get and set modifyers allow the variable to be read and modified from outside the class.
        public List<double> OriginalQuantities { get; set; }
        //public double array to store the original quantities of each ingredient


        public Recipe() //constructor takes two integers as arguments 
        {
            
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
            OriginalQuantities = new List<double>();

        }

        /*
      Author: Doyle, B. (2016) 
      title of the book: C♯ Programming: From problem analysis to program design. Boston, MA: Cengage Learning. pg 204 -215 & 400-430
      accessed:  20 april 2023
      */

        public static void DisplayRecipes(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("List of Recipes:");
            recipes.Sort((r1, r2) => string.Compare(r1.RecipeName, r2.RecipeName)); // Sort the recipes list in alphabetical order by name

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.RecipeName);
            }
        }


        public void SetName(string name)
        {
            RecipeName = name;
        }

        public void EnterRecipes()
        {
            List<Recipe> recipes = new List<Recipe>(); // List to store recipes

            while (true)
            {
                Console.WriteLine("What is the name of the recipe: ");
                string recipeName = Console.ReadLine();

                Console.WriteLine("\nEnter the number of ingredients:");
                int numIngredients = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the number of steps:");
                int numSteps = int.Parse(Console.ReadLine());

                Recipe recipe = new Recipe();

                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"\nEnter the name of ingredient {i + 1}: ");
                    string name = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of {name}: ");
                    double quantity = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter the unit of measurement for {name}: ");
                    string unit = Console.ReadLine();

                    Ingredient ingredient = new Ingredient(name, quantity, unit);
                    recipe.AddIngredient(ingredient);
                }

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"\nEnter step {i + 1}: ");
                    string step = Console.ReadLine();
                    recipe.AddStep(step);
                }

                recipe.PrintRecipe();

                Console.WriteLine("\nDo you want to scale the recipe? (y/n)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Console.WriteLine("Enter the scaling factor: " +
                                      "\n0.5 (Half) \n  2 (Double) \n  3 (Triple): \n");

                    double factor = double.Parse(Console.ReadLine());
                    recipe.ScaleRecipe(factor);

                    Console.WriteLine("\nScaled Recipe:");
                    recipe.PrintRecipe();
                }

                Console.WriteLine("Do you want to reset the quantities to the original values? (y/n)");
                answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    recipe.ResetQuantities();

                    Console.WriteLine("\nThe recipe quantities have been reset to their original values:");
                    recipe.PrintRecipe();
                }

                recipes.Add(recipe);

                Console.WriteLine("\nDo you want to enter another recipe? (y/n)");
                answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    break;
                }
            }
        }






        public void AddIngredient(Ingredient ingredient)// Method that adds a new ingredient to the Ingredients array at the specified index
        {
            Ingredients.Add(ingredient);
            OriginalQuantities.Add(ingredient.Quantity);
        }

        public void AddStep(string step) // Method that adds a new step to the Steps array at the specified index
        {
            Steps.Add(step);  // Assigns the specified description string to the specified index in the Steps array

        }

        public void ScaleRecipe(double factor)
        {
            if (factor == 0.5) // If the factor is 0.5, multiply by 0.5 instead of the input factor
            {
                for (int i = 0; i < Ingredients.Count; i++)// loop iterates over all the ingredients in the recipe.
                {
                    Ingredients[i].Quantity = OriginalQuantities[i] / 2; // Scale down the quantity of each ingredient by half
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
            }
        }

        /*John S
       https://stackoverflow.com/questions/2675196/c-sharp-method-to-scale-values
       accessed: 24 april 2023
         */


        public void PrintRecipe()// Method that prints the recipe to the console
        {
            Console.WriteLine($"\nRecipe Name: {RecipeName}"); ;

            Console.WriteLine("\nIngredients:");
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }
        public void ResetQuantities()
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].Quantity = OriginalQuantities[i]; // Reset the quantity of each ingredient to its original value
            }
        }
        public void ClearRecipe()
        {
            RecipeName = string.Empty;
            Ingredients.Clear();
            Steps.Clear();
            OriginalQuantities.Clear();
        }
    }
}






