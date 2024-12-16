using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string user = Console.ReadLine();

            Activity activity = null;
            if (user == "1")
            {
                activity = new BreathingActivity();
            }

            else if (user == "2")
            {
                activity = new ReflectingActivity();
            }

            else if (user == "3")
            {
                activity = new ListingActivity();
            }

            else if (user == "4")
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again");
                Thread.Sleep(3000);
            }

            activity.Run();
        }
    }
}