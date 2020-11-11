using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine3
{
    /// <summary>
    /// Class in charge of heating up the water in the machine
    /// </summary>
    public class BoilWater
    {
        public void Boil(Water water)
        {
            water.temp = 100;
            Console.WriteLine("Water is now at " + water.temp + "Celsius, and boiling.");
        }
    }
}
