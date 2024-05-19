public class BreathingActivity : Activity
{
    public BreathingActivity(String name, String description, int duration) : base(name, description, duration)
    {
    }

    //-------------------------------------------------

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }
}