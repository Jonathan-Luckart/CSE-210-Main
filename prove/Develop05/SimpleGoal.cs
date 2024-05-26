public class SimpleGoal : Goal
{
    public SimpleGoal(String name, String description, int points) : base(name, description, points)
    {
    }

//for loading
    public SimpleGoal(String name, String description, int points, String markedDone) : base(name, description, points)
    {
        _markedDone = markedDone;
    }

    //----------------------------------------------

    public override void RecordEvent()
    {
        _markedDone = "X";

        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
    }

    public override string GetStringRepresentation()
    {
        String sgFull = $"SG:{_shortName}#{_description}#{_points}#{_markedDone}";
        return sgFull;
    }
}