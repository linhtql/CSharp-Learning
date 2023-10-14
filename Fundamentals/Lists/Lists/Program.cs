using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(9);
            numbers.AddRange(new int[] { 5, 6, 7 });

            foreach (var number in numbers) { Console.WriteLine(number); }

            // IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // LastIndexOf()

            // property Count

            // Remove()
        }
    }
}
