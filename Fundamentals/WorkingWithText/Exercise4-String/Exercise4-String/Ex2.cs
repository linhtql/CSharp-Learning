using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_String
{
    internal class Ex2
    {
        public static void main()
        {
            Console.WriteLine("Enter list or enter to quit");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) )
            {
                Console.WriteLine("Thanks for use my program");
                return;
            } else
            {
                var numbers = Array.ConvertAll(input.Split('-'), s => int.Parse(s));
                if (IsDuplicate(numbers))
                {
                    Console.WriteLine("Duplicate");
                }
            }
        }

        private static bool IsDuplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] == arr[i]) {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
