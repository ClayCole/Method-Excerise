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

            Console.WriteLine($"Thanks, {userName}! Here is your Profile");
            Console.WriteLine($"----------------------------------------");


            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color:{color}");
            Console.WriteLine($"Favorite Animal:{animal}");
            Console.WriteLine($"Favorite Musicain:{musician}");

        }
    }
}

