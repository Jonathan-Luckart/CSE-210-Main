using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        //----------------------------

        Running running = new Running(DateTime.Parse("06/20/2024"), 15, 2);
        Cycling cycling = new Cycling(DateTime.Parse("09/06/2024"), 30, 15);
        Swimming swimming = new Swimming(DateTime.Parse("12/17/2024"), 40, 27);
        _activityList.Add(running);
        _activityList.Add(cycling);
        _activityList.Add(swimming);

        Console.WriteLine();

        foreach (Activity activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}