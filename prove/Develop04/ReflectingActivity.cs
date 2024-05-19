public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //---------------------------------------------------------------------

    public ReflectingActivity(String name, String description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    //---------------------------------------------------------------------

    public void Run()
    {
        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();
        Console.Write("When you have something in mind press enter to continue.");
        String input = Console.ReadLine();

        if (input == "")
        {
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
            Console.Write("You may begin in: ");
            ShowCountDown(6);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            DateTime currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                //do thing
                DisplayQuestions();
                ShowSpinner(5);
                Console.WriteLine();
                currentTime = DateTime.Now;
            }

        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("nuh uh");
        }
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        return _prompts[promptIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(_questions.Count);
        return _questions[questionIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}