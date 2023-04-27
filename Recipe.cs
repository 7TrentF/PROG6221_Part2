using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Recipe
    {
        public int NumIngredients { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public int NumSteps { get; set; }
        public string[] Steps { get; set; }
        public double[] OriginalQuantities { get; set; }

        public Recipe(int numIngredients, int numSteps)
        {
            NumIngredients = numIngredients;
            Ingredients = new Ingredient[numIngredients];
            NumSteps = numSteps;
            Steps = new string[numSteps];
        }

        public void AddIngredient(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredient(name, quantity, unit);
        }

        public void AddStep(int index, string description)
        {
            Steps[index] = description;

        }

        public void ScaleRecipe(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void PrintRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($" {ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"\n {i + 1}. {Steps[i]}. ");//orders steps in a numeric list 
            }
        }
    }
}
