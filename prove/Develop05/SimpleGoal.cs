public class SimpleGoal : Goal
{
    private Boolean _isComplete = false;

    //-----------------------------------

    public SimpleGoal(String name, String description, int points) : base(name, description, points)
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