public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    //----------------------------------------

    public ListingActivity(String name, String description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    //---------------------------------------------------------

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in... ");
        ShowCountDown(6);
        Console.WriteLine();
        Console.WriteLine();
        List<string> userResponse = GetListFromUser();
        Console.WriteLine($"You listed {userResponse.Count} items! ");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        List<string> userList = new List<string>();

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            String addToList = Console.ReadLine();
            userList.Add(addToList);

            currentTime = DateTime.Now;
        }

        return userList;
    }
}