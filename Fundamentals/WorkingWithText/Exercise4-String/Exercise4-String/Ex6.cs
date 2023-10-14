using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_String
{
    internal class Ex6
    {
        public static int CountVowels(string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (isVowels(word[i])) count++;
            }
            return count;
        }

        public static bool isVowels(char word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach(char vowel in vowels)
            {
                if (word.Equals(vowel)) return true;
            }
            return false;
        }
    }
}
