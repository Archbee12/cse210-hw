using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do 
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            
            // Console.Write("What is the magic number? ");
            // string magicNumber = Console.ReadLine();
            // int number = int.Parse(magicNumber);

            int guess = -1;

            int guesses = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                guesses++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You guessed {guesses} times to get it right");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }   while (response == "yes");
    Console.WriteLine("Thank you for playing!");               
    }
}