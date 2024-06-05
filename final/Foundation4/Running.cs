public class Running : Activity
{
    private float _distance;

    //---------------------------

    public Running(DateTime date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    //-----------------------------------------

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMMM yyyy")} Running ({_length} min) - Distance {_distance} miles, Speed {Speed():F2} mph, Pace: {Pace():F2} min per mile.";
    }

    public override float Speed()
    {
        float answer = (_distance / _length) * 60;
        return answer;
    }

    public override float Pace()
    {
        return _length / _distance;
    }
}