using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// We'll start with an abstract Pizza class and all the
    /// concrete pizzas will derive from this
    /// </summary>
    public abstract class Pizza
    {
        public void prepare()
        {
            Console.WriteLine("preparing " + name);
            Console.WriteLine("tossing " + dough  +"... ");
            Console.WriteLine("adding sauce " + sauce + "... ");
            Console.WriteLine("adding toppings: ");
            for(int i=0; i< topping.Count; i++)
            {
                Console.WriteLine("  " + topping[i]);
            }
        }

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in offical pizzastore box");
        }
        
        public virtual string name { get; set; }
        public virtual string dough { get; set; }
        public virtual string sauce { get; set; }
        public virtual ArrayList topping { get; set; }
    }
}
