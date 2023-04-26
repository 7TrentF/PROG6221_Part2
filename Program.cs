using System;
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

            //prompt user to enter the ingredients
            Console.WriteLine("Enter the number of ingredients:");

            //method converts the user input read using console.readline into an integer value and is assigned to the variable numIngredients
            int numIngredients = int.Parse(Console.ReadLine()); 
           
            //prompt user to enter the number of steps 
            Console.WriteLine("Enter the number of steps:");
            //method converts the user input read using console.readline into an integer value and is assigned to the variable numSteps
            int numSteps = int.Parse(Console.ReadLine());

            //object to create instance of the Recipe class,constructor takes two integer arguments numIngredients and numSteps
            Recipe recipe = new Recipe(numIngredients, numSteps);

            //for loop to get the details of ingredients from the user 
            for (int i = 0; i < numIngredients; i++)
            {
                //prompt user to enter name of ingredient
                Console.WriteLine($"\nEnter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();//assigns user input to variable name  

                Console.WriteLine($"Enter the quantity of {name}: ");  //prompt user to enter quantity of ingredient
                double quantity = double.Parse(Console.ReadLine());  //Converts user input to a double and assigns input to variable quantity 

                Console.WriteLine($"Enter the unit of measurement for {name}: ");  //prompt user to enter unit of measurment for the ingredient
                string unit = Console.ReadLine();  // assigns input to variable quantity

            }

            //for loop to get a description of the step for the recipe. 
            //loop runs until the number of steps the user inputs is fufilled 
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nEnter step and description{i + 1}: "); //prompt user to enter a description for each step that the user inputs to the for loop
                string step = Console.ReadLine();

                //Object to call the method AddStep from the Recipe class, takes two arguments 
                recipe.AddStep(i, step);

            }

        }
    }
}
