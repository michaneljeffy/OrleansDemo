using System;
using Orleans;
using System.Threading.Tasks;

namespace IGrains
{
    public interface IBasic : IGrainWithIntegerKey
    {
        Task<string> SayHello(string helloContext);
    }
}
