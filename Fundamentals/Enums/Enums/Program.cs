﻿namespace CCsharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method); // express
            Console.WriteLine((int) method); // 3

            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";

            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod); // express
        }

    }
}