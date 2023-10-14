using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Array
{
    // 4- Write a program and ask the user to continuously
    // enter a number or type "Quit" to exit. The list of
    // numbers may include duplicates. Display the unique
    // numbers that the user has entered.
    internal class Ex4
    {
        public static void input()
        {
            int[] numbers = new int[5];
            int count = 0;
            while(true)
            {
                Console.WriteLine("Enter number or Quit");
                string input = Console.ReadLine();

                if (input.Equals("Quit"))
                {
                    break;
                }

                int number = int.Parse(input);

                if(!IsDuplicate(number, numbers))
                {
                    numbers[count++] = number;
                }
            }
            Display(numbers);
        }
        public static void Display(int[] arr)
        {
            Array.ForEach(arr, number => Console.WriteLine(number));
        }
        public static bool IsDuplicate(int number, int[] arr)
        {
            foreach(int i in arr)
            {
                if (number == i) return true;
            }
            return false;
        }
    }
}
