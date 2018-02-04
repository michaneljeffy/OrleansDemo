using System;
using Orleans;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = Orleans.Runtime.Configuration.ClusterConfiguration.LocalhostPrimarySilo(2234, 1234);

            Orleans.Runtime.Host.SiloHost sliohost = new Orleans.Runtime.Host.SiloHost("Test", config);

            sliohost.InitializeOrleansSilo();

            sliohost.StartOrleansSilo();

            if (sliohost.IsStarted)
            {
                Console.WriteLine("sliohost start success");
            }

            else
            {
                Console.WriteLine("slio start fail");
            }

            Console.ReadKey();
        }
    }
}
