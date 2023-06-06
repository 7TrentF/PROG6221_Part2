using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part1
{
    internal class Ingredient
    {
       
        public string Name { get; set; } //public string to store the name of the ingredient 
                                         //allow the variable to be read and modified from outside the ingredient 
        public double Quantity { get; set; }  //public double to store the quantity of the specified ingredient 
                                              //allow the variable to be read and modified from outside the ingredient class
        public string Unit { get; set; } //public string variable to store the unit of measurement of the ingredient
                                         //allow the variable to be read and modified from outside the ingredient class

   
       
    }
}
