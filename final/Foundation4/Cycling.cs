public class Cycling : Activity
{
    private float _speed;

    //---------------------------

    public Cycling(DateTime date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    //---------------------------------------------------

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMMM yyyy")} Cycling ({_length} min) - Distance {Distance():F2} miles, Speed {_speed} mph, Pace: {Pace():F2} min per mile.";
    }

    public override float Distance()
    {
        return _speed * _length / 60;
    }

    public override float Pace()
    {
        return 60 / _speed;
    }
}