using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Array
{
    public class Ex3
    {
        // Write a program and ask the user to enter 5 numbers.
        // If a number has been previously entered, display an
        // error message and ask the user to re-try. Once the
        // user successfully enters 5 unique numbers, sort them
        // and display the result on the console.

        public static void main()
        {
            int[] numbers = new int[5];
            int count = 0;
            int number;
            while (true)
            {
                Console.WriteLine("Enter your number");
                number = int.Parse(Console.ReadLine());
                
                if (!isExists(number, numbers))
                {
                    numbers[count++] = number;
                } else 
                {
                    Console.WriteLine("Number is exists, pls re-type!");
                }

                if (count == 5) break;
            }

            Console.WriteLine("-----sort and display------");
            bubbleSort(numbers);
            Action<int> action = number => { Console.WriteLine(number); };
            Array.ForEach(numbers, action);

        }

        public static bool isExists(int number, int[] arr)
        {
            foreach (int i in arr)
            {
                if (i == number)
                {
                    return true;
                }
            }
            return false;
        }

        public static void bubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }


    }
}
