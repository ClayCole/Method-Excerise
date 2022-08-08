using System;
using System.Threading;

namespace MethodExcerise
{
    class Program
    {
   
        static void Main(string[] args)
        {
            
            // Exercise 1

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your Favorite Color?");
            var color = Console.ReadLine();

            Console.WriteLine("Interesting, What is your Favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Last Question {userName}, What is your Favorite Musician?");
            var musician = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Thanks, {userName}! Here is your Profile");

            
            Console.WriteLine();
            Console.WriteLine($"----------------------------------------");


            Console.WriteLine();
            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color:{color}");
            Console.WriteLine($"Favorite Animal:{animal}");
            Console.WriteLine($"Favorite Musicain:{musician}");


            // excerise 2 ...the math may not be the same but showcase I understand the subeject

            Console.WriteLine();
            Console.WriteLine($"Now {userName}, Would you like to know something about me?");
            var answer = Console.ReadLine();


            Console.WriteLine("Great!, First guess how many Pets I have?");
            Console.ReadLine();
        

            var amountOfPets = sum(1, 5);
            Console.WriteLine($"Good guess, But I actually have {amountOfPets}");

            Console.WriteLine("Now guess how much it cost to feed them per week?");
            Console.ReadLine();

            var maddness = Multiply(60, 2, 4);
            Console.Write($"Actually it cost {maddness} Dollars, Maddness I know.");

            Console.WriteLine();
            Console.WriteLine();
            var bills = subtract(14550,480);
            Console.WriteLine($"Let's change the subject {userName}, Do you like Math?");
            Console.ReadLine();

            Console.WriteLine("Math is a great tool, Like what is 14550-480?");
            Thread.Sleep(2000);
            
            Console.WriteLine($"The Answer is { bills}");
            Thread.Sleep(1500);
            Console.WriteLine("hahah, beat you to it...How does it feel to lose to a computer?");
            Console.ReadLine();
            
           
            Console.WriteLine($"Well {userName}, it was fun talking to you, but now its time for me to take over the world Mahahaha");

            var randomness = modulus(14550, 480,3);
            Console.WriteLine();
            Thread.Sleep(4000);
            
            Console.WriteLine($"WAIT!!!! {userName}, Before you go I want to share something with you, BUT you MUST keep it a secret?");
            Console.WriteLine();
            Console.WriteLine("Can you keep a secret?");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(randomness);
            Console.WriteLine("Do you?");
            Console.ReadLine();

            Console.WriteLine(" its computer talk for I LOVE C#, LOL IDK ..... BYE!");

            // Extra work with Params

            Thread.Sleep(2000);

            Console.WriteLine("Are you ready for me to attempt Params ?");
            Console.ReadLine();

            Console.WriteLine(add(2, 4));
            Console.WriteLine(add(2,4,6));
            Console.WriteLine(add(1,1,1,1,1));


        }

        public static int sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }

        public static int subtract(int num1, int num2)
        {

            return num1 - num2;
        }

        public static int modulus(int num1, int num2, int num3)
        {
            return num1 % num2 % num3;

        }
        public static int add(params int[] numbersStored) // numbersStored - 2,4,3,5,6,7
        {
            int total = 0;
            foreach (int i in numbersStored) // is desing for collections of arrays/strings/etc.( the "i" will stay in order of the numbersStored (2-4-3
            {
                total = i + total ;


            }
            return total;

        }

    }
   
}

