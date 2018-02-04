using System;
using IGrains;
using System.Threading.Tasks;
using Orleans;

namespace Grains
{
    public class BasicGrain :Grain, IGrains.IBasic
    {
        public Task<string> SayHello(string helloContext)
        {
            Console.WriteLine("{0}:{1}", DateTime.Now.ToString("HH:mm:ss:fff"), helloContext);
            return Task.FromResult<string>("done");
        }
    }
}
