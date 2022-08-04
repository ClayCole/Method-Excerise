using System;

namespace MethodExcerise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your Favorite Color?");
            var color = Console.ReadLine();

            Console.WriteLine("Interesting, What is your Favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Last Question {userName}, What is your Favorite Musician?");
            var musician = Console.ReadLine();

            Console.WriteLine($"I appericate your time {userName}, Have a Good Day!");
        }
    }
}

