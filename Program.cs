using System;
using System.Threading;

namespace docker_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 30; i++ ) {
                Thread.Sleep(1000);
                Console.WriteLine("Hello World!"+i.ToString());
            }
        }
    }
}
