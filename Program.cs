using System;

namespace MethodExcerise
{
    class Program
    {
        public static int sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {


            var amountOfPets = sum(1, 2);
            var maddness = Multiply(60, 2, 4);


            // I feel like I am missing something above as when I run the code it just does the bottom part? 

            // Exercise 1

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your Favorite Color?");
            var color = Console.ReadLine();

            Console.WriteLine("Interesting, What is your Favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Last Question {userName}, What is your Favorite Musician?");
            var musician = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your Profile");
            Console.WriteLine($"----------------------------------------");


            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color:{color}");
            Console.WriteLine($"Favorite Animal:{animal}");
            Console.WriteLine($"Favorite Musicain:{musician}");

           



        }
    }
}

