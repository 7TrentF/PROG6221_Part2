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
            while (true)
            {

                Console.WriteLine("What is the name of the recipe: "); //prompt user to enter name of recipe 
                string recipeName = Console.ReadLine();  //reads user input and assignes input to the variable recipeName

                //prompt user to enter the number of  ingredients
                Console.WriteLine("Enter the number of ingredients:");

                //method converts the user input read using console.readline into an integer value and is assigned to the variable numIngredients
                int numIngredients = int.Parse(Console.ReadLine());

                //prompt user to enter the number of steps 
                Console.WriteLine("Enter the number of steps:");
                //method converts the user input read using console.readline into an integer value and is assigned to the variable numSteps
                int numSteps = int.Parse(Console.ReadLine());

                //object to create instance of the Recipe class,constructor takes two integer arguments numIngredients and numSteps
                Recipe recipe = new Recipe(numIngredients, numSteps);

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

                    recipe.AddIngredient(i, name, quantity, unit);

                }

               
                for (int i = 0; i < numSteps; i++) //for loop to get a description of the step for the recipe. 
                                                   //loop runs until the number of steps the user inputs is fufilled 
                {
                    Console.WriteLine($"\nEnter step {i + 1}: "); //prompt user to enter a description for each step that the user inputs to the for loop
                    string step = Console.ReadLine();                            //reads user input and assignes input to the variable step

                    
                    recipe.AddStep(i, step); //Object to call the method AddStep from the Recipe class, takes two arguments 

                }

                Console.WriteLine("\n---------------------------------------" +
                                    $"\nRecipe to make: {recipeName} \n" +
                                    "---------------------------------------");
                recipe.PrintRecipe();
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("\nDo you want to scale the recipe? (y/n)");
                string answer = Console.ReadLine().ToLower();


                if (answer == "y")
                {
                    Console.WriteLine("Enter the scaling factor: " +
                                      "\n0.5 (Half) \n  2 (Double, or \n  3 (Triple):");

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

                    Console.WriteLine("\n The recipe quantities have been reset to their original values:");
                    recipe.PrintRecipe();
                }

                Console.WriteLine("\nDo you want to enter a new recipe? (y/n)");
                answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    break;
                  
                }
                

                recipe.ClearRecipe();

                Console.ReadLine();
            }
        }
    }

}