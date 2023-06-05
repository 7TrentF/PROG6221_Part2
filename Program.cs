using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>(); // List to store recipes

            while (true)
            {

                Console.WriteLine("What is the name of the recipe: "); //prompt user to enter name of recipe 
                string recipeName = Console.ReadLine();  //reads user input and assignes input to the variable recipeName

                //prompt user to enter the number of  ingredients
                Console.WriteLine("\nEnter the number of ingredients:");

                //method converts the user input read using console.readline into an integer value and is assigned to the variable numIngredients
                int numIngredients = int.Parse(Console.ReadLine());

                //prompt user to enter the number of steps 
                Console.WriteLine("\nEnter the number of steps:");
                //method converts the user input read using console.readline into an integer value and is assigned to the variable numSteps
                int numSteps = int.Parse(Console.ReadLine());

                //object to create instance of the Recipe class,constructor takes two integer arguments numIngredients and numSteps
                Recipe recipe = new Recipe(recipeName);

               
                //for loop to get the details of ingredients from the user, loops as many times as the user defines
                for (int i = 0; i < numIngredients; i++)
                {
                    //prompt user to enter name of ingredient
                    Console.WriteLine($"\nEnter the name of ingredient {i + 1}: ");
                    string name = Console.ReadLine();                                     //reads user input and assignes input to the variable 

                    Console.WriteLine($"Enter the quantity of {name}: ");                //prompt user to enter quantity of ingredient
                    double quantity = double.Parse(Console.ReadLine());                 //Converts user input to a double and assigns input to variable quantity 

                    Console.WriteLine($"Enter the unit of measurement for {name}: ");  //prompt user to enter unit of measurment for the ingredient
                    string unit = Console.ReadLine();                                  //reads user input and assignes input to the variable unit 

                    Ingredient ingredient = new Ingredient(name, quantity, unit);
                    recipe.AddIngredient(ingredient);
                   
                }

               
                for (int i = 0; i < numSteps; i++) //for loop to get a description of the step for the recipe. 
                                                   //loop runs until the number of steps the user inputs is fufilled 
                {
                    Console.WriteLine($"\nEnter step {i + 1}: "); //prompt user to enter a description for each step that the user inputs to the for loop
                    string step = Console.ReadLine();                            //reads user input and assignes input to the variable step
                    recipe.AddStep(step);

                   //Object to call the method AddStep from the Recipe class, takes two arguments 

                }


                recipe.PrintRecipe(); // calls PrintRecipe method from Recipe class and prints the current recipe to the console.

 /*
Author: Doyle, B. (2016) 
title of the book: C♯ Programming: From problem analysis to program design. Boston, MA: Cengage Learning. 
accessed:  25 april 2023
*/

                Console.WriteLine("\nDo you want to scale the recipe? (y/n)");
                string answer = Console.ReadLine().ToLower(); // Asks the user if they want to scale the recipe and reads their response.

                if (answer == "y")
                {
                    Console.WriteLine("Enter the scaling factor: " +
                                      "\n0.5 (Half) \n  2 (Double, or \n  3 (Triple): \n"); // Asks the user to enter a scaling factor.

                    double factor = double.Parse(Console.ReadLine()); // Reads the user's input and parses it as a double.

                    recipe.ScaleRecipe(factor); // Scales the recipe by the given factor.

                    Console.WriteLine("\nScaled Recipe:");
                    recipe.PrintRecipe(); // Prints the scaled recipe to the console.
                }

                Console.WriteLine("Do you want to reset the quantities to the original values? (y/n)");
                answer = Console.ReadLine().ToLower(); // Asks the user if they want to reset the recipe to its original quantities and reads their response.

                if (answer == "y")
                {
                    recipe.ResetQuantities(); // Resets the recipe to its original quantities.

                    Console.WriteLine("\n The recipe quantities have been reset to their original values:");
                    //recipe.PrintRecipe();
                }
                else
                {
                    recipe.ClearRecipe(); // Clears the current recipe.

                }
                recipes.Add(recipe);
               

                Console.WriteLine("\nDo you want to enter a new recipe? (y/n)");
                answer = Console.ReadLine().ToLower(); // Asks the user if they want to enter a new recipe and reads their response.

                if (answer == "n")
                {
                   
                    break; // If the user doesn't want to enter a new recipe, exits the loop.
                }

             
                Console.ReadLine(); // Reads the user's input to pause the program. 

            }
        }
    }

}