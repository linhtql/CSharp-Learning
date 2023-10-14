using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Linh";
            bool isWorking = true;

            var a = "Quang Tran";

            Console.WriteLine("number: " + number);
            Console.WriteLine("count: " + count);
            Console.WriteLine("totalPrice: " + totalPrice);
            Console.WriteLine("character: " + character);
            Console.WriteLine("firstName: " + firstName);
            Console.WriteLine("isWorking: " + isWorking);

            Console.WriteLine("int minValue: " + int.MinValue);
            Console.WriteLine("int maxValue: " + int.MaxValue);

            // hang so
            const float PI = 3.14f;
            //    PI = 3.15;
            Console.WriteLine("PI: " + PI);
        }

        
    }
}