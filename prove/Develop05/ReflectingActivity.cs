using System;

public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };

  private List<string> _questions = new List<string>
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
  };

  public ReflectingActivity()
  {
    SetName("Reflection");
    SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
  }

  public void DisplayPrompt()
  {
    Random random = new Random();
    string _prompt = _prompts[random.Next(_prompts.Count)];
    Console.WriteLine("\nConsider the following prompt:");
    Console.WriteLine($"\n--- {_prompt} ---");
    Console.WriteLine("When you have something in mind press enter to continue.");
    Console.ReadLine();
  }

  public void DisplayQuestions()
  {
    Random random = new Random();
    int _duration = GetDuration();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Thread.Sleep(1000);
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();
    while (_duration > 0)
    {
      string _question = _questions[random.Next(_questions.Count)];
      Console.Write($"\n- {_question} ");
      ShowSpinner(3);
      _duration -= 5;
    }

  }

  public override void Run()
  {
    DisplayStartingMessage();
    DisplayPrompt();


    ShowSpinner(2);

    GetDuration();
    DisplayQuestions();
    DisplayEndingMessage();
  }
}
