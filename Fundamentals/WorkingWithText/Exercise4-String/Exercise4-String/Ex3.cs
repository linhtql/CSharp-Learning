using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_String
{
    internal class Ex3
    {
        public static void main()
        {
            Console.WriteLine("Enter time: ");
            string time = Console.ReadLine();
            string[] times = time.Split(':');
            int hour = int.Parse(times[0]);
            int minute = int.Parse(times[1]);

            if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59))
            {
                Console.WriteLine("Invalid Time");
            } 
            else
            {
                Console.WriteLine("OK");
            }
            
        
        }
    }
}
