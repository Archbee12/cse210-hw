using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 4), 45, 28);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 5), 30, 20);

        var activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}