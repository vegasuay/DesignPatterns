using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Whip is a decorator, we extend CondimentDecorator
    /// </summary>
    public class Whip:CondimentDecorator
    {
        /// <summary>
        /// we're going to instantiate Whip with a ref to a Beverage
        /// </summary>
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        /// <summary>
        /// we need to compute the cost of our beverage with Whip.
        /// first we delegate the call to the object we're decorating,
        /// so that it can campute the cost, we add the cost of Whip to result
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }
}
