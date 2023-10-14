using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine(a / b); // 3
            Console.WriteLine((float) a / (float) b); // 3.333

            Console.WriteLine(a == b); // false
            Console.WriteLine(!(a == b)); // true
        }
    }
}