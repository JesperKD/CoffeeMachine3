using CoffeeMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for Coffe \npress 2 for Tea \npress 3 for Espresso");
            string drinkChoice = Console.ReadLine();
            if (drinkChoice == "1")
            {
                CoffeeMachine cm = new CoffeeMachine("MochaMaster");
                FillCoffee fillCof = new FillCoffee();
                BoilWater boilwater = new BoilWater();
                BrewingCoffee brewingCof = new BrewingCoffee();
                CoffeeBean cb = new CoffeeBean();
                CoffeeFilter cf = new CoffeeFilter();
                Water water = new Water();

                cm.TurnOn();
                Console.WriteLine();

                Console.WriteLine("How many cups of coffee would you like to brew?");
                water.cupsofwater = int.Parse(Console.ReadLine());
                Console.WriteLine();


                fillCof.FillWithWater(cm, water);
                Console.WriteLine();
                fillCof.FillWithTaste(cm, cb);
                Console.WriteLine();

                Console.WriteLine("Press ENTER to brew coffee");
                Console.ReadKey();
                Console.WriteLine();

                boilwater.Boil(water);
                Console.WriteLine();
                brewingCof.Brew(cm, water);

                cm.TurnOff();
            }
            else if (drinkChoice == "2")
            {
                CoffeeMachine cm = new CoffeeMachine("TeaMaster");
                BoilWater boilwater = new BoilWater();
                TeaLeaf tl = new TeaLeaf();
                FillTea filltea = new FillTea();
                BrewingTea brewingTea = new BrewingTea();
                Water water = new Water();

                cm.TurnOn();
                Console.WriteLine();

                Console.WriteLine("How many cups of tea would you like to brew?");
                water.cupsofwater = int.Parse(Console.ReadLine());
                Console.WriteLine();


                filltea.FillWithWater(cm, water);
                Console.WriteLine();
                filltea.FillWithTaste(cm, tl);
                Console.WriteLine();

                Console.WriteLine("Press ENTER to brew tea");
                Console.ReadKey();
                Console.WriteLine();

                boilwater.Boil(water);
                Console.WriteLine();
                brewingTea.Brew(cm, water);

                cm.TurnOff();

            }
            else if (drinkChoice == "3")
            {
                CoffeeMachine cm = new CoffeeMachine("MochaMaster");
                FillCoffee fillCof = new FillCoffee();
                BoilWater boilwater = new BoilWater();
                BrewingEspresso brewingEsp = new BrewingEspresso();
                CoffeeBean cb = new CoffeeBean();
                CoffeeFilter cf = new CoffeeFilter();
                Water water = new Water();
                Stamping stamping = new Stamping();

                cm.TurnOn();
                Console.WriteLine();

                Console.WriteLine("How many cups of espresso would you like to brew?");
                water.cupsofwater = int.Parse(Console.ReadLine());
                Console.WriteLine();


                fillCof.FillWithWater(cm, water);
                Console.WriteLine();
                stamping.StampBeans(cm, cb);
                Console.WriteLine();
                fillCof.FillWithTaste(cm, cb);
                Console.WriteLine();

                Console.WriteLine("Press ENTER to brew Espresso");
                Console.ReadKey();
                Console.WriteLine();

                boilwater.Boil(water);
                Console.WriteLine();

                for (int i = 0; i < water.cupsofwater; i++)
                {
                    brewingEsp.Brew(cm, water);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                cm.TurnOff();
            }
            else
            {
                Console.WriteLine("Input Error!");
            }


            Console.ReadKey();

        }
    }
}
