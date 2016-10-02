﻿using System;
using System.ServiceModel;

namespace SelfHostedServiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SampleService)))
            {
                host.Open();

                Console.WriteLine("The service is ready at {0}", host.BaseAddresses);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();
                host.Close();
            }

        }
    }
}
