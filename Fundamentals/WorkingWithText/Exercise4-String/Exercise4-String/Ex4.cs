using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_String
{
    internal class Ex4
    {
        public static string CreatePascalCase(string input)
        {
            string[] words = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach(string word in words)
            {
                string tmp = word.ToLower();
                sb.Append(tmp.Substring(0,1).ToUpper());
                sb.Append(tmp.Substring(1, tmp.Length - 1).ToLower());
            }


            return sb.ToString();
        }
    }
}
