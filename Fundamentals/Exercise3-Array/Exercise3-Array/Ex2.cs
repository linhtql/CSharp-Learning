using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Array
{
    // 2- Write a program and ask the user to
    // enter their name. Use an array to reverse
    // the name and then store the result in a
    // new string. Display the reversed name on the console.

    public class Ex2
    {
        public static void ReverseName()
        {
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            StringBuilder sb = new StringBuilder();

            for(int i = chars.Length - 1; i >= 0; i--)
            {
                sb.Append(chars[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
