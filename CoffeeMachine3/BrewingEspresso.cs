using CoffeeMachine3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class BrewingEspresso : Ibrew
    {
        public void Brew(CoffeeMachine3.CoffeeMachine cm, Water w)
        {
            Console.WriteLine(cm.Brand + " is brewing a cup of espresso.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cm.Brand + " is done brewing a cup of espresso.");
        }
    }
}
