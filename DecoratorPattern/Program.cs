using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///order a expresso, no condiments. print desc and cost
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.getDescription() + " €" + beverage.cost());

            ///order Decaf object, wrap it with a mocha, second mocha in a whip
            Beverage beverage2 = new Decaf();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " €" + beverage2.cost());
        }
    }
}
