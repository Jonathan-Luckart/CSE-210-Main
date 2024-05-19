public class Activity
{
    private String _name = "";
    private String _description = "";
    protected int _duration = 0;

    //-------------------------------------

    public Activity(String name, String description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //-----------------------------------------------

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity. ");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How Long, in seconds, would you like for your session? ");
        int timeToUse = int.Parse(Console.ReadLine());
        _duration = timeToUse;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int fullRevo)
    {
        List<string> animatedStr = new List<string>();
        #region 
        animatedStr.Add("|");
        animatedStr.Add("/");
        animatedStr.Add("-");
        animatedStr.Add("\\");
        animatedStr.Add("|");
        animatedStr.Add("/");
        animatedStr.Add("-");
        animatedStr.Add("\\");
        #endregion

        for (int i = fullRevo; i > 0; i--)
            foreach (String carrot in animatedStr)
            {
                Console.Write(carrot);
                Thread.Sleep(250);
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
}