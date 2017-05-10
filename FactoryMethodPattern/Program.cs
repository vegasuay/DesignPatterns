using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            //PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("ha pedido una pizza: " + pizza.name + "\n");

            //pizza = chicagoStore.orderPizza("cheese");
            //Console.WriteLine("ha pedido una pizza: " + pizza.name + "\n");
        }
    }
}
