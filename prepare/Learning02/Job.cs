using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int startYear;
    public int endYear;
    public void Display()
    {
        Console.WriteLine($"{_company} {_jobTitle} {startYear}-{endYear}");
    }
}