using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Graphics Designer";
        job2._company = "Udemy";
        job2.startYear = 2022;
        job2.endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "UI/UX Designer";
        job3._company = "Udemy";
        job3.startYear = 2023;
        job3.endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Deborah Sarah Okon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}