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


        public Recipe(string recipeName) //constructor takes two integers as arguments 
        {
            RecipeName = recipeName;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
            OriginalQuantities = new List<double>();
           
        }

  /*
Author: Doyle, B. (2016) 
title of the book: C♯ Programming: From problem analysis to program design. Boston, MA: Cengage Learning. pg 204 -215 & 400-430
accessed:  20 april 2023
*/

        public void AddIngredient(Ingredient ingredient)// Method that adds a new ingredient to the Ingredients array at the specified index
        {
            Ingredients.Add(ingredient);
            OriginalQuantities.Add(ingredient.Quantity);
        }

        public void AddStep( string step) // Method that adds a new step to the Steps array at the specified index
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
            Console.WriteLine("\n---------------------------------------" +
                                 "\nRecipe:\n" +
                                 "---------------------------------------");

            Console.WriteLine("Ingredients:");  // Outputs the header for the list of ingredients
            {
                for (int i = 0; i < Ingredients.Length; i++) // Iterate over each Ingredient object in the Ingredients array using a for loop
                {
                    Ingredient ingredient = Ingredients[i]; // Get the current Ingredient object

                    Console.WriteLine($" {ingredient.Quantity} {ingredient.Unit} {ingredient.Name}"); // Outputs the Quantity, Unit, and Name properties of the current Ingredient in a formatted string
                    /*Samuel Kubjana (2023)
                     * 
                     */
                }
            }

            Console.WriteLine("\nSteps:"); // Outputs the header for the list of steps
            for (int i = 0; i < Steps.Length; i++)  // Iterates over each element in the Steps array using a for loop with an index variable
            {
                Console.WriteLine($"\n {i + 1}. {Steps[i]}. ");//orders steps in a numbered list 
            }
            Console.WriteLine("\n---------------------------------------");
        }

        public void ResetQuantities() // Method that resets the quantities of all ingredients in the recipe to their original values
        {
            for (int i = 0; i < Ingredients.Length; i++) // Loop through each ingredient in the recipe
            {
                Ingredients[i].Quantity = OriginalQuantities[i]; // Set the quantity of the current Ingredient object to its original value
            }

            
            Console.WriteLine("\nOriginal Quantities:"); // Print the heading

            // Loop through each element of the OriginalQuantities array and print its value along with the corresponding ingredient name and unit
            for (int i = 0; i < OriginalQuantities.Length; i++)
            {
                // Use string interpolation to format the output string
                Console.WriteLine($"{OriginalQuantities[i]} " + $"{Ingredients[i].Unit} " + $"{Ingredients[i].Name}");
            }

        }

        public void ClearRecipe()  // Method that clears the recipe by creating new empty arrays for Ingredients and Steps
        {
            Ingredients = new Ingredient[NumIngredients]; //Creates a new array of Ingredient objects with the same length as the original array
            Steps = new string[NumSteps];  // Creates a new array of string objects with the same length as the original array

            for (int i = 0; i < NumIngredients; i++)
            {
                OriginalQuantities[i] = 0.0;
            }
        }
    }
}






