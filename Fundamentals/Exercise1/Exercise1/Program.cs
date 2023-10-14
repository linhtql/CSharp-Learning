using System;

namespace CSharpFundamentals
{
    class Progaram
    {
        static void Main(string[] args)
        {
            // 1- Write a program and ask the user to enter a number.
            // The number should be between 1 to 10. If the user enters a valid number,
            // display "Valid" on the console. Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered
            // into input boxes need to be validated.)

            // Ex1();

            // Write a program which takes two numbers from the console and displays the maximum of the two.
            //Ex2();

            // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            //Ex3();

            // Your job is to write a program for a speed camera. For simplicity, ignore the details such as
            // camera, sensors, etc and focus purely on the logic. Write a program that asks the user
            // to enter the speed limit. Once set, the program asks for the speed of a car. If
            // the user enters a value less than the speed limit, program should display Ok on
            // the console. If the value is above the speed limit, the program should calculate
            // the number of demerit points. For every 5km/hr above the speed limit, 1 demerit
            // points should be incurred and displayed on the console. If the number of demerit
            // points is above 12, the program should display License Suspended.
            Ex4();
        }

        private static void Ex4()
        {
            Console.WriteLine("Enter the speed limit");
            float speedLimit = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car");
            float speedCar = float.Parse(Console.ReadLine());


            if (speedCar <= speedLimit) {
                Console.WriteLine("OK");
            } else
            {
                int demeritPoints = (int) (speedCar - speedLimit) / 5;
                Console.WriteLine($"Demerit Points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

            
        }

        private static void Ex3()
        {
            try
            {
                Console.WriteLine("Enter the width of the image: ");
                int width = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height of the image: ");
                int height = int.Parse(Console.ReadLine());

                if (height > 0 && width > 0) {
                    if (width > height)
                    {
                        Console.WriteLine("landscape");
                    } else if (width < height)
                    {
                        Console.WriteLine("portrait");
                    } else
                    {
                        Console.WriteLine("square");
                    }
                } else
                {
                    Console.WriteLine("Invalid input");

                }

            } catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            {

            }
        }

        private static void Ex2()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine(maxNumber);

        }

        public static void Ex1()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); 
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}