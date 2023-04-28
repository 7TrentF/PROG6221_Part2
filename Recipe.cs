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
       
        public int NumIngredients { get; set; }  //public integer variable representing the number of ingredients required for the recipe.
                                                 //get and set modifyers allow the variable to be read and modified from outside the class.
        public Ingredient[] Ingredients { get; set; } //public array to store the ingredients of the recipe
                                                      //get and set modifyers allow the variable to be read and modified from outside the class.
        public int NumSteps { get; set; } //public integer variable to store the number of steps for the recipe 
                                          //get and set modifyers allow the variable to be read and modified from outside the class.
        public string[] Steps { get; set;} //public stirng array to store the description of the steps for the recipe.
                                           //get and set modifyers allow the variable to be read and modified from outside the class.
        public double[] OriginalQuantities { get; set; } //public double array to store the original quantities of each ingredient

 
        public Recipe(int numIngredients, int numSteps) //constructor takes two integers as arguments 
        {
            NumIngredients = numIngredients;                 // integer variable NumIngredients set as the variable numIngredients 
            Ingredients = new Ingredient[numIngredients];     //Ingredients initialized as new array, numIngredients defines the type and the length of the array
            NumSteps = numSteps;                              // integer variable NumSteps set as the variable numSteps
            Steps = new string[numSteps];                     // Creates a new array of strings with the specified size
            OriginalQuantities = new double[numIngredients]; // initialize OriginalQuantities array

            for (int i = 0; i < numIngredients; i++) // for loop initializes each element in the OriginalQuantities array to 0.0,
            {
                OriginalQuantities[i] = 0.0;

            }
        }

  /*
Author: Doyle, B. (2016) 
title of the book: C♯ Programming: From problem analysis to program design. Boston, MA: Cengage Learning. pg 204 -215 & 400-430
accessed:  20 april 2023
*/

        public void AddIngredient(int index, string name, double quantity, string unit)// Method that adds a new ingredient to the Ingredients array at the specified index
        {
            Ingredients[index] = new Ingredient(name, quantity, unit); // Creates a new Ingredient object with the specified properties and assigns it to the specified index in the Ingredients array
            OriginalQuantities[index] = quantity;
        }

        public void AddStep(int index, string description) // Method that adds a new step to the Steps array at the specified index
        {
            Steps[index] = description;  // Assigns the specified description string to the specified index in the Steps array

        }

        public void ScaleRecipe(double factor)
        {
            if (factor == 0.5) // If the factor is 0.5, multiply by 0.5 instead of the input factor
            {
                for (int i = 0; i < Ingredients.Length; i++)// loop iterates over all the ingredients in the recipe.
                {
                    Ingredients[i].Quantity *= 0.5; // Multiply the quantity of the current Ingredient object by 0.5
                }
            }

            else // For all other factors, multiply by the input factor
            {
                for (int i = 0; i < Ingredients.Length; i++)
                {
                    Ingredients[i].Quantity *= factor; // Multiply the quantity of the current Ingredient object by the factor
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
                Console.WriteLine($"{OriginalQuantities[i]}" + $"\n{Ingredients[i].Unit}" + $"\n{Ingredients[i].Name}");
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






