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
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nEnter 'add' to add a new recipe, 'list' to display all recipes, 'display' to view a specific recipe, or 'exit' to quit:");
                string command = Console.ReadLine();

                if (command == "add")
                {
                    recipe.EnterRecipes();
                }
                else if (command == "list")
                {
                   recipe.DisplayRecipes();
                }


                Console.WriteLine("Enter the name of the recipe: ");
                string name = Console.ReadLine();
                recipe.SetName(name);




                Console.ReadLine(); // Reads the user's input to pause the program. 

            }
        }
    }
}

