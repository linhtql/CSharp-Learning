using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_String
{
    internal class Ex1
    {
        public static bool isConsecutive(string str)
        {
            var numbers = Array.ConvertAll(str.Split('-'), s => int.Parse(s));

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1] || numbers[i] - 1 != numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
