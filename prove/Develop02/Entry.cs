using System;


public class Entry
{
  public string _date;
  public string _promptText;
  public string _text;

  public Entry(string date, string promptText, string text)
  {
    _date = date;
    _promptText = promptText;
    _text = text;
  }

  public void WriteEntry(StreamWriter writer)
  {
    writer.WriteLine($"{_date}|{_promptText}|{_text}");
  }

  public void Display()
  {
    Console.WriteLine($"Entry at: {_date}");
    Console.WriteLine($"In response to: {_promptText}");
    Console.WriteLine(_text);
    Console.WriteLine();
  }

  public static Entry CreateEntries()
  {
    string date = DateTime.Now.ToString();
    string promptText = new Prompts().GetPrompts();
    Console.WriteLine(promptText);
    string text = Console.ReadLine();
    Entry addEntry = new Entry(date, promptText, text);
    return addEntry;
  }
}