using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(a);

            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;

            arr1[0] = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            // other
            Console.WriteLine("---Other----");
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // 1

            // but
            var person = new Person() { age = 21};

            MakeOld(person);
            Console.WriteLine(person.age); // 31

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }

    public class Person
    {
        public int age;
    }
}
