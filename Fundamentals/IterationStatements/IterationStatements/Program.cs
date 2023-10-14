namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            Console.WriteLine("---for loop---");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Linh deep try:)");
            }

            // for each
            Console.WriteLine("---for each---");
            var fullname = "Tran Quang Linh";
            foreach(var item in fullname)
            {
                Console.WriteLine(item);
            }

            var numbers = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine("--for each numbers---");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // while loop
            Console.WriteLine("--while loop---");
            var j = 0;
            while (j < 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            // enter your name
            while (true)
            {
                Console.WriteLine("Type your name");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input)) {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
