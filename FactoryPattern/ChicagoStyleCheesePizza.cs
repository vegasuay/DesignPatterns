using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChicagoStyleCheesePizza:Pizza
    {
        /// <summary>
        /// the Chicago pizza has its own marinara style sauce and thin crust
        /// </summary>
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style sauce and cheese pizza";
            dough = "thin crust dough";
            sauce = "ganster sauce";
            ArrayList _toppings = new ArrayList();
            _toppings.Add("greated reggiano cheese");
            topping = _toppings;
        }
    }
}
