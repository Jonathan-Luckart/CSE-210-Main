public class Swimming : Activity
{
    private float _lapAmount;

    //-----------------------

    public Swimming(DateTime date, int length, int lapAmount) : base(date, length)
    {
        _lapAmount = lapAmount;
    }

    //-------------------------------------------

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMMM yyyy")} Swimming ({_length} min) - Distance {Distance():F2} miles, Speed {Speed():F2} mph, Pace: {Pace():F2} min per mile.";
    }

    public override float Distance()
    {
        Double answer = _lapAmount * 50 / 1000 * 0.62;
        float newAnswer = (float)answer;

        return newAnswer;
    }

    public override float Speed()
    {
        return 60 / Pace();
    }

    public override float Pace()
    {
        return _length / Distance();
    }
}
