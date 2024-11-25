using System;
using System.Collections.Generic;
using System.IO;

// Allowed user save file as csv

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

// Allows user to save file
  public void SaveToFile()
  {
    Console.Write("Enter filename to save: ");
    string fileName = Console.ReadLine();
    string extension = Path.GetExtension(fileName)?.ToLower();
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (var entry in _entries)
        if (extension == ".csv")
        {
          // Escape special characters for CSV format
          string csvLine = $"{EscapeCsv(entry._date)}," +
                           $"{EscapeCsv(entry._promptText)}," +
                           $"{EscapeCsv(entry._text)}";
          writer.WriteLine(csvLine);
        }
      else 
      {
        entry.WriteEntry(writer);
      }
    }
    Console.WriteLine("Journal saved successfully.");
  }

// Method to escape CSV fields
  private string EscapeCsv(string field)
  {
    if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
    {
      return $"\"{field.Replace("\"", "\"\"")}\"";
    }
    return field;
  }

// Allows user to load file as a csv file
  public void LoadFromFile()
  {
    Console.Write("Enter filename to load: ");
    string fileName = Console.ReadLine();
    string extension = Path.GetExtension(fileName)?.ToLower();
    if (File.Exists(fileName))
    {
      _entries.Clear();
      string[] lines = File.ReadAllLines(fileName);
      foreach (var line in lines)
      {
        if (extension == ".csv")
        {
          string[] parts = line.Split('|');

          if (parts.Length == 3)
          {
            _entries.Add(new Entry(parts[1], parts[2], parts[0]));
          }
        }
        else 
        {
          string[] parts = line.Split('|');
          if (parts.Length == 3)
          {
            _entries.Add(new Entry(parts[1], parts[2], parts[0]));
          }
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
