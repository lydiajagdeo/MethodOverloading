using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(4, 6));
            Console.WriteLine(Methods.Add(1.2m, 3.5m));
            Console.WriteLine(Methods.Add(6, 4, true));
        }
    }
}

