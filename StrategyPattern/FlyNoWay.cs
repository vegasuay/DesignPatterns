using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyNoWay:IFlyBehavior
    {
        public void fly()
        {
            Console.Write("No puedo volar!!");
        }
    }
}
