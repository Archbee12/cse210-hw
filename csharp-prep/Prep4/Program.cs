using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string  userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0) 
            {
                numbers.Add(number);
            }
        }

// This computes the total numbers in the list        
        int sum = 0;
        foreach (int userNumber in numbers)
        {
            sum += userNumber;
        }
        Console.WriteLine($"The sume is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int userNumber in numbers)
        {
            if (userNumber > max)
            {
                max = userNumber;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

// This iterates over the list of numbers to find the smallest postive number
        int? smallestPositive = null;
        
        foreach (int userNumber in numbers)
        {
            if (userNumber > 0)
            {
                if (smallestPositive == null || userNumber < smallestPositive)
                smallestPositive = userNumber;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");


// This sorts the lists of numbers in an ascending order
        numbers.Sort();
        
        foreach (int userNumber in numbers)
        {
            Console.WriteLine(userNumber);
        }

    }
}