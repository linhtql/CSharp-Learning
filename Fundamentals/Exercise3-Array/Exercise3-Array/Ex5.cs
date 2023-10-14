using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Array
{
    // Write a program and ask the user to supply a list of
    // comma separated numbers (e.g 5, 1, 9, 2, 10).
    // If the list is empty or includes less than 5 numbers,
    // display "Invalid List" and ask the user to re-try; otherwise,
    // display the 3 smallest numbers in the list.
    internal class Ex5
    {
        public static void main()
        {
            int[] numbers;
            while (true)
            {
                Console.WriteLine("Enter list");
                string input = Console.ReadLine();

                string[] splits = input.Split(',');
                numbers = new int[splits.Length];
                int count = 0;
                Array.ForEach(splits, i => { numbers[count++] = int.Parse(i); });

                if (isValid(numbers))
                {
                    break;
                }
                

            }
            bubbleSort(numbers);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static bool isValid(int[] input)
        {
            

            if (input.Length < 5) 
            {
                Console.WriteLine("Invalid List");
                return false;
            }

            return true;
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
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;
                    }
                }
            }
        }
    }
}
