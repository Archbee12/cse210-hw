using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new ();
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                journal.CreateEntries();
            }
            else if (userResponse == "2")
            {
                journal.Display();
            }
            else if (userResponse == "3")
            {
                journal.SaveToFile();
            }
            else if (userResponse == "4")
            {
                journal.LoadFromFile();
            }
            else if (userResponse == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else 
            {
                Console.WriteLine("Invalid Option, Please try again");
            }
        }
        
    }
}