public class EternalGoal : Goal
{
    public EternalGoal(String name, String description, int points) : base(name, description, points)
    {
    }

    //----------------------------------------------

     public override void RecordEvent()
    {
        //init
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}