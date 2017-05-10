using FactoryMethodPattern.ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public virtual string name { get; set; }
        public virtual Dough dough { get; set; }
        public virtual Sauce sauce { get; set; }
        public virtual Cheese cheese { get; set; }
        public virtual Veggies veggies { get; set; }
        public virtual Pepperoni pepperoni { get; set; }
        public virtual Clams clams { get; set; }

        public abstract void prepare();

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
    }
}
