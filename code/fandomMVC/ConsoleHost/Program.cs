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
           ServiceHost HostProductService = new ServiceHost(typeof(ProductServices));
            HostProductService.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();

            HostProductService.Close();
        }
    }
}
