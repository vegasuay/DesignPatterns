using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyRocketPowered:IFlyBehavior
    {
        public void fly()
        {
            Console.Write("Estoy volando desde un rocket");
        }
    }
}
