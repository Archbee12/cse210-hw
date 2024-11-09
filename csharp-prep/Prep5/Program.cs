using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int square = squareNumber(userNumber);

        DisplayResult(userName, square);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static string PromptUserName()
        {
            Console.Write($"Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write($"Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int squareNumber(int number)
        {
            int userSquare = number * number;
            return userSquare;
        }

        static void DisplayResult(string name, int userSquare )
        {
            Console.Write($"{name}, the square of your number is {userSquare}");
        }
    }
}