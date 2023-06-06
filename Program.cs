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
            RecipeCollection rc = new RecipeCollection();  // Create an instance of the RecipeCollection class

            while (true)
            {
                Console.WriteLine("\nType 'add' to add a new recipe,\n'list' to display all recipes,\n'display' to view a specific recipe,\n or 'exit' to quit:");
                string command = Console.ReadLine();//reads user input 

                if (command == "add")
                {
                    rc.EnterRecipe();  // calls EnterRecipe method from Recipe class.
                }
                else if (command == "list")
                {
                    rc.DisplayRecipeList();  // calls DisplayRecipeList method from Recipe class to print a a list of the recipe names in alphabetical order
                }
                else if (command == "display")
                {
                    Console.WriteLine("Enter the name of the recipe to display:");
                    string recipeName = Console.ReadLine();
                    Console.WriteLine();

                    rc.DisplayRecipe(recipeName);   // calls DisplayRecipeList method from Recipe class to display the recipe that the user specifies 
                }
                else if (command == "exit")
                {
                    break;  // Exit the loop and quit the program
                }
            }


            Console.ReadLine(); // Reads the user's input to pause the program. 

            }
        }
    }


