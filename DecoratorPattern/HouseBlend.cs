using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend:Beverage
    {
        private string description;

        public HouseBlend()
        {
            description = "HouseBlend";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return .99;
        }
    }
}
