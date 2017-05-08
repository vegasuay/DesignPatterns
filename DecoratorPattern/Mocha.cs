using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// mocha is a decorator, we extend CondimentDecorator
    /// </summary>
    public class Mocha:CondimentDecorator
    {
        /// <summary>
        /// we're going to instantiate Mocha with a ref to a Beverage
        /// </summary>
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        /// <summary>
        /// we need to compute the cost of our beverage with mocha.
        /// first we delegate the call to the object we're decorating,
        /// so that it can campute the cost, we add the cost of mocha to result
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
