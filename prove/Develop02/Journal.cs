using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  public List<Entry> _entries = new();
  

  public void CreateEntries()
  {
    _entries.Add(Entry.CreateEntries());
  }

  public void Display()
  {
    // Displays no entries when count of entry is 0
    if (_entries.Count == 0)
    {
      Console.WriteLine("No entries in the journal.");
    }

    else 
    {
      Console.WriteLine("");
      foreach (var entry in _entries)
      {
        entry.Display();
      }
    }
    
  }

  public void SaveToFile()
  {
    Console.Write("Enter filename to save: ");
    string fileName = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (var entry in _entries)
      {
        entry.WriteEntry(writer);
      }
    }
    Console.WriteLine("Journal saved successfully.");
  }

  public void LoadFromFile()
  {
    Console.Write("Enter filename to load: ");
    string fileName = Console.ReadLine();
    if (File.Exists(fileName))
    {
      _entries.Clear();
      string[] lines = File.ReadAllLines(fileName);
      foreach (var line in lines)
      {
        string[] parts = line.Split('|');

        if (parts.Length == 3)
        {
          _entries.Add(new Entry(parts[1], parts[2], parts[0]));
        }
      }
      Console.WriteLine("Journal loaded successfully.");
    }
    else
    {
      Console.WriteLine($"No file named {fileName} found.");
    }    
  }
}
