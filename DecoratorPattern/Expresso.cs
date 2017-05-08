using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Expresso: Beverage
    {
        public Expresso()
        {
            this.setDescription("Espresso");    
        }        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return 1.99;
        }
    }
}
