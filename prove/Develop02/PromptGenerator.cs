public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);

        return _prompts[promptIndex];
    }
}