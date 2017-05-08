using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// SteamedMilk is a decorator, we extend CondimentDecorator
    /// </summary>
    public class SteamedMilk:CondimentDecorator
    {
        /// <summary>
        /// we're going to instantiate SteamedMilk with a ref to a Beverage
        /// </summary>
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", SteamedMilk";
        }

        /// <summary>
        /// we need to compute the cost of our beverage with SteamedMilk.
        /// first we delegate the call to the object we're decorating,
        /// so that it can campute the cost, we add the cost of SteamedMilk to result
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return .30 + beverage.cost();
        }
    }
}
