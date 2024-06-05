public abstract class Activity
{
    protected DateTime _date;
    protected int _length;

    //-----------------------

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    //---------------------------------

    public virtual float Distance()
    {
        return 0;
    }

    public virtual float Speed()
    {
        return 0;
    }

    public virtual float Pace()
    {
        return 0;
    }

    public abstract String GetSummary();
}