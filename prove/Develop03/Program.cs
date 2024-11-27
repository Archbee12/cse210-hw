using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
// using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = LoadScripturesFromFile("scriptures.txt");

        Random random = new Random();
        List<string> hiddenWords = new List<string>();
        // Reference reference = new Reference("John", 3, 16);
        // Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." );

        while (true)
        {
            // This code will select a random scripture
            var scripture = scriptures[random.Next(scriptures.Count)];

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to exit. ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }
                
                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPresenting a new scripture. ");
 
            hiddenWords.Clear();
        }
    }

    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        var scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(fileName);

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 4)
            {
                var reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                var scripture = new Scripture(reference, parts[3]);
                scriptures.Add(scripture);
            }

            else if (parts.Length == 5)
            {
                var reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                var scripture = new Scripture(reference, parts[4]);
                scriptures.Add(scripture);
            }
        }
        return scriptures;
    }

}