public class Fraction 
{
    private int _top;
    private int _bottom;

    // ----------------------------------------------

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

// ----------------------------------------------------------

    public String GetFractionString()
    {
        String construct = $"{_top}/{_bottom}";

        return construct;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

/* ---------------------------------------------------------------------
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int topSet)
    {
        _top = topSet;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int botSet)
    {
        _bottom = botSet;
    } */
}