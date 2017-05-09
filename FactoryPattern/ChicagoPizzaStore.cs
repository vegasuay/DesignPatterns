using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChicagoPizzaStore:PizzaStore
    {
        /// <summary>
        /// createPizza return a Pizza, and the subclass is
        /// fully responsible for wich concrete Pizza it instantiates
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected override Pizza createPizza(string item)
        {
            //Here's where we create our concrete class. For each type of Pizza
            if (item.Equals("cheese"))
                return new ChicagoStyleCheesePizza();
            /*
            else if (item.Equals("veggie"))
                return new NYStyleVeggiePizza();
            else if (item.Equals("pepperoni"))
                return new NYStylePepperoniPizza();
            */
            else
                return null;
        }
    }
}
