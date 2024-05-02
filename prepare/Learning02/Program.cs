using System;

class Program
{
    static void Main(string[] args)
    {
        //start
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._jobTitle = "Pizza Guy";
        job2._company = "Daily Bugle";
        job2._startYear = 2012;
        job2._endYear = 2013;

        Console.WriteLine();
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        Console.WriteLine();

        Resume myResume = new Resume();

        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine();
        myResume.DisplayResumeDetails();
        Console.WriteLine();
    }
}