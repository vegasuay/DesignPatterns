using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        /// <summary>
        /// a factory method is abstract so the subclasses are counted on to handle object creation
        /// a factory method returns a product that is typically used within wethod defined in superclass
        /// a factory method isolates the clients from knowing what king of concrete product is created
        /// all responsibility has been moved into a method that acts as a factory
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        protected abstract Pizza createPizza(string type);
    }
}
