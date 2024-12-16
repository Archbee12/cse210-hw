using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());
    }

        MathAssignment assign2 = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8.19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeWorkList());
}