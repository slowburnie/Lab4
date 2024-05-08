using System;
using System.ServiceModel;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(L2.Service)))
            {
                host.Open();
                Console.WriteLine("Хост розпочав роботу");
                Console.ReadLine();
            }

        }
    }
}
