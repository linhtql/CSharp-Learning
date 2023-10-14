using System;

namespace TypeConversion 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b; // 1
            Console.WriteLine(i);
             
            int c = 2;
            byte d = (byte) c; // 2

            int f = 1000;
            byte g = (byte) f;
            Console.WriteLine(g); //232

            try
            {
                string number = "12345";
                byte j = Convert.ToByte(number);
                Console.WriteLine(j);
            } catch(Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


        }
    }

}