using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            //same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("Same instance\n");

            //Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for(int i = 0; i < 15; i++)
            {
                string server = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + server);
            }

            //wait for user
            Console.ReadKey();
        }
    }
}
