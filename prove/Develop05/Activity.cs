using System;

public abstract class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  // public Activity(string name, string description)
  // {
  //   _name = name;
  //   _description = description;
  // }

  public void SetName(string name)
  {
    _name = name;
  }

  public string GetName()
  {
    return _name;
  }

  public void SetDescription(string description)
  {
    _description = description;
  }

  public string GetDescription()
  {
    return _description;
  }

  public void SetDuration(int duration)
  {
    _duration = duration;
  }
  public int GetDuration()
  {
    return _duration;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"\nWelcome to the {GetName()} Activity.");
    Thread.Sleep(1000);
    Console.WriteLine($"\n{_description}");
    ShowSpinner(2);
    Thread.Sleep(2000);

    Console.Write("\nHow long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get Ready...");

    ShowSpinner(5);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("\nGood job!");
    Thread.Sleep(2000);
    Console.WriteLine($"\nYou have completed the {GetName()} activity for {GetDuration()} seconds");
    ShowSpinner(5);
  }

  public void ShowSpinner(int seconds)
  {
    for (int i = 0; i < seconds; i++)
    {
      Console.Write("|");
      Thread.Sleep(250);
      Console.Write("\b/");
      Thread.Sleep(250);
      Console.Write("\b-");
      Thread.Sleep(250);
      Console.Write("\b\\");
      Thread.Sleep(250);
      Console.Write("\b|");
      Thread.Sleep(250);
      Console.Write("\b/");
      Thread.Sleep(250);
      Console.Write("\b-");
      Thread.Sleep(250);
      Console.Write("\b\\");
      Console.Write("\b \b");
    }
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }

  public void ShowAnimation(string message, int duration)
  {
    int totalSteps = 10;
    int delay = duration * 1000 / (2 * totalSteps);

    for (int i = 1; i <= totalSteps; i++)
    {
      Console.Clear();
      Console.WriteLine(message.PadLeft(i * 2));
      System.Threading.Thread.Sleep(delay + i * 20);
    }

    for (int i = totalSteps; i >= 1; i--)
    {
      Console.Clear();
      Console.WriteLine(message.PadLeft(i * 2));
      System.Threading.Thread.Sleep(delay + (totalSteps - i) * 20);
    }
  }

  public abstract void Run();
}