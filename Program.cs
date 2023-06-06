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
            RecipeCollection rc = new RecipeCollection();

            while (true)
            {
                Console.WriteLine("\nEnter 'add' to add a new recipe,\n'list' to display all recipes, 'display' to view a specific recipe,\n or 'exit' to quit:");
                string command = Console.ReadLine();

                if (command == "add")
                {
                    rc.EnterRecipe();
                }
                else if (command == "list")
                {
                    rc.DisplayRecipeList();
                }
                else if (command == "display")
                {
                    Console.WriteLine("Enter the name of the recipe to display:");
                    string recipeName = Console.ReadLine();

                   rc.DisplayRecipe(recipeName);
                }
                else if (command == "exit")
                {
                    break;
                }


                Console.ReadLine(); // Reads the user's input to pause the program. 

            }
        }
    }
}

