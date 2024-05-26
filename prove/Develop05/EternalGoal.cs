public class EternalGoal : Goal
{
    public EternalGoal(String name, String description, int points) : base(name, description, points)
    {
    }

    //----------------------------------------------

     public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
    }

    public override string GetStringRepresentation()
    {
        String egFull = $"EG:{_shortName}#{_description}#{_points}";
        return egFull;
    }
}