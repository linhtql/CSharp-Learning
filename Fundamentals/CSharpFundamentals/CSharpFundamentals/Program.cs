using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Linh";
            person.lastName = "Tran Quang";
            person.Introduce();

            Calculator calculator = new Calculator();
            Console.WriteLine("result: " + calculator.add(1, 9));

        }
    }
}