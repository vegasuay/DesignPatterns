using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decaf:Beverage
    {
        private string description;

        public Decaf()
        {
            description = "Decaf";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return 1.09;
        }
    }
}
