using ControlFlow;
using System;
namespace CSharpFundamental


{
    
    class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("it's morning");
            } else if (hour >= 12  && hour <= 18)
            {
                Console.WriteLine("it's afternoon");
            }
            else
            {
                Console.WriteLine("it's evening");
            }

            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 19.95f : 29.95f;

            Console.WriteLine(price);


            var season = Season.Autum;

            switch(season)
            {
                case Season.Autum:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("We've got promotion.");
                    Console.WriteLine("It's perfect go to beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that reason.");
                    break;

            }

        }
    }
}