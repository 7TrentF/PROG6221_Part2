using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Delegate
    {
        public delegate void NotifyUser(string recipeName, int totalCalories); // Delegate declaration for notifying the user about recipe calories

        public void NotifyUserExceededCalories(string recipeName, int totalCalories)  // Notify the user when a recipe exceeds 300 calories
        {
            Console.WriteLine($"\nWARNING!!!: " +
                              $"\nThe recipe '{recipeName}' has exceeded 300 calories." +
                              $"\nEating more than 300 to 400 calories in a meal will likely cause a surplus of energy.\n" +
                              $"\nTotal calories: {totalCalories}");


        }
        /* 
         *  /*  Author: Doyle, B. (2016) 
            title of the book: C♯ Programming: From problem analysis to program design.Boston, MA: Cengage Learning. pg 686-690
            accessed:  6 june 2023

            Author: Samuel Kubjana
            Class example: DelegateExample
        */

    }
}
