using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation, You passed!");
        }
        
        if (grade < 70)
        {
            Console.WriteLine($"You must have at least a 70 to pass the class");
        }

        // Stretch Challenge 
        string sign = "";
        int lastDigit = grade%10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }


        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign} ");
    }
}