using System;

namespace Program
{
    class BasicStrings
    {
        static void Main(string[] args)
        {
            string firstName = "Linh";
            string lastName = "Tran Quang";
            // concat
            Console.WriteLine("-----Concat-----");
            string fullname1 = "Linh" + " " + "Tran Quang";
            Console.WriteLine(fullname1);

            // join
            Console.WriteLine("-----Join-----");
            string[] names = { "Linh", "Tran Quang" };
            string fullname2 = string.Join(" ", names);
            Console.WriteLine(fullname2);

            // format
            Console.WriteLine("-----Format-----");
            string fullname3 = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullname3);

            // use @
            Console.WriteLine("---use @----");
            string text = "Hi Linh \nLook into the following paths \nc:\\folder1\\folder2 \nc:\\folder3\\folder4";
            Console.WriteLine(text);

            // can replace
            Console.WriteLine("----can repcle-----");
            string text1 = @"Hi Linh
                             Look into the following paths
                             c:\folder1\folder2
                             c:\folder3\folder4";


        }
    }
}