using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.product
{
    /// <summary>
    /// the ProductB2 class
    /// </summary>
    class Wolf: Carnivore
    {
        public override void Eat(Herbivore h)
        {
            //eat Bison
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
