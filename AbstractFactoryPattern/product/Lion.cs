using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.product
{
    /// <summary>
    /// the ProductB1 class
    /// </summary>
    class Lion: Carnivore
    {
        public override void Eat(Herbivore h)
        {
            //come wilddebeest
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
