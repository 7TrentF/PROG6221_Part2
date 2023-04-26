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
            int numIngredients = int.Parse(Console.ReadLine());


            //for loop to get the details of ingredients from the user 
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nEnter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

            }

            //prompt user to enter the number of steps 
            Console.WriteLine("Enter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nEnter step and description{i + 1}: ");
                string step = Console.ReadLine();


            }

        }
    }
}
