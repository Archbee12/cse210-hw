using System;

public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    SetName("Breathing");
    SetDescription("This activity will help you relax by walking you through breating in and out slowly. Clear your mind and focus on your breathing.");
  } 

  public override void Run()
  {
    DisplayStartingMessage();
    int _duration = GetDuration();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    // while (_duration > 0)
    // {
    //   Console.Write($"\nBreathe in...");
    //   ShowCountDown(5);
    //   _duration -= 5;

    //   if (_duration <= 0) 
    //   {
    //     break;
    //   }  

    //   Console.Write("Now breathe out...");
    //   ShowCountDown(6);
    //   _duration -= 6;
    // }
    while (DateTime.Now < endTime)
    {
      ShowAnimation("Breathe In...", _duration / 6);
      ShowAnimation("Now Breathe Out...", _duration / 5);
    }

    DisplayEndingMessage();
  }
}