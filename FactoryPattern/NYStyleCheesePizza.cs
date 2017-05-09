using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYStyleCheesePizza:Pizza
    {
        /// <summary>
        /// the NY pizza has its own marinara style sauce and thin crust
        /// </summary>
        public NYStyleCheesePizza()
        {
            name = "NY Style sauce and cheese pizza";
            dough = "thin crust dough";
            sauce = "Marina sauce";
            ArrayList _toppings = new ArrayList();
            _toppings.Add("greated reggiano cheese");
            topping = _toppings;
        }
    }
}
