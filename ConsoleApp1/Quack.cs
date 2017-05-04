using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.Write("Quack!!");
        }
    }
}
