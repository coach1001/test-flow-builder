using CRTP.Builders;
using System;

namespace CRTP
{
    class Program
    {
        static void Main(string[] args)
        {
            var flow = new BaseBuilder("flow").Build();
            Console.WriteLine("Hello World!");
        }
    }
}
