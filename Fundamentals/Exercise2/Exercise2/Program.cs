namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to count how many numbers between
            // 1 and 100 are divisible by 3 with no remainder.
            // Display the count on the console.

            //Ex1();

            // 2- Write a program and continuously ask the
            // user to enter a number or "ok" to exit. Calculate the sum
            // of all the previously entered numbers
            // and display it on the console.

            //Ex2();

            // Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on
            // the console. For example, if the user enters 5,
            // the program should calculate 5 x 4 x 3 x 2 x 1 and
            // display it as 5! = 120.

            // Console.WriteLine("Enter the number");
            // int number = int.Parse(Console.ReadLine());
            // Console.WriteLine($"factorial of {number} is: " + Factorial(number));

            // >---------------------<

            // Write a program that picks a random number between'
            // 1 and 10. Give the user 4 chances to guess the number.
            // If the user guesses the number, display
            // “You won"; otherwise, display “You lost".
            // (To make sure the program is behaving correctly,
            // you can display the secret number on the console first.)
            // Ex4();

            // Write a program and ask the user to enter a series of numbers
            // separated by comma. Find the maximum of the numbers and display
            // it on the console. For example, if the user enters “5, 3, 8, 1, 4",
            // the program should display 8.

            
            string input = "5, 3, 8, 1, 4";
            Console.WriteLine(Ex5(input));


        }

        private static int Ex5(string input)
        {
            int maxValue = int.MinValue;
            string[] numbers = input.Split(',');
            foreach(string number in numbers)
            {
                int tmp = int.Parse(number);
                if (tmp > maxValue )
                {
                    maxValue = tmp;
                }
            }
            return maxValue;
        }

        private static void Ex4()
        {
            int secretNumber = new Random().Next(1, 10);
            Console.WriteLine("Enter your lucky number");
            int luckyNumber = int.Parse(Console.ReadLine());

            string result;
            if (secretNumber == luckyNumber)
            {
                Console.WriteLine("You won");
            } else
            {
                Console.WriteLine("You lost, the secret number is " + secretNumber);
            }

        }

        private static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
            
        }

        private static void Ex2()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter \"ok\" to exits or number to cal sum");
                string input = Console.ReadLine();
                if (input == "ok")
                {
                    Console.WriteLine("sum: " + sum);
                    break;
                }
                else
                {
                    int number = int.Parse(input);
                    sum += number;
                }


            }
        }

        public static void Ex1()
        {
            int i = 1;
            int count = 0;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("From 1 To 100 has "+ count + " number devisibe by 3");
        }
    }
}