using System;
using Orleans;
using IGrains;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            Run();

            Console.ReadKey();
        }

        static async void Run()
        {
            var config = Orleans.Runtime.Configuration.ClientConfiguration.LocalhostSilo(1234);
            GrainClient.Initialize(config);

            IGrains.IBasic agrain = GrainClient.GrainFactory.GetGrain<IGrains.IBasic>(314);

            string result = await agrain.SayHello("Hello World!");

            Console.WriteLine(result);
        }
    }
}
