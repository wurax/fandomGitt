using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Contracts;
using System.Threading.Tasks;
using Services;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost HostProductService1 = new ServiceHost(typeof(ProductServices));
            HostProductService1.Open();

            //  ServiceHost HostProductService2 = new ServiceHost(typeof(OrderService));
            //  HostProductService2.Open();

            //  ServiceHost HostProductService3 = new ServiceHost(typeof(OrderLineService));
            //  HostProductService3.Open();


            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();

            HostProductService1.Close();
            // HostProductService2.Close();
            // HostProductService3.Close();
        }
    }
}
