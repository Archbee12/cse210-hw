using System;

public class ListingActivity : Activity
{
  protected int _count;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?", "Who are people that you have helped this week?", 
    "When have you felt the Holy Ghost this month?", 
    "Who are some of your personal heroes?"
  };

  public ListingActivity()
  {
    SetName("Listing");
    SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
  }

  public void IncrementCount()
  {
    _count++;
  }

  public int GetCount()
  {
    return _count;
  }
  private string GetRandomPrompt()
  {
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
  }

  private List<string> GetListFromUser(int duration)
  {
    _count = 0;
    List<string> userList = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(duration);
    Console.WriteLine("Start listing items!");
    while (DateTime.Now < endTime)
    {
      Console.Write("- ");
      string input = Console.ReadLine();
      if (!string.IsNullOrEmpty(input))
      {
        userList.Add(input);
        IncrementCount();
      }
    }
    return userList;
  }
  public override void Run()
  {
    DisplayStartingMessage();
    string randomPrompt = GetRandomPrompt();
    Console.WriteLine($"\nPrompt:{randomPrompt}");
    ShowCountDown(5);

    int duration = GetDuration();
    List<string> userList = GetListFromUser(duration);
    Console.WriteLine($"You listed {GetCount()} items.");

    DisplayEndingMessage();    

  }
}
