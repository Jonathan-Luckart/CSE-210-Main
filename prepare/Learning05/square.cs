public class Square : Shape
{
    private Double _side;

    //----------------------------------------

    public Square(String color, Double side) : base(color)
    {
        _side = side;
    }

    //------------------------------------------

    public override double GetArea()
    {
        Double area = _side * _side;
        return area;
    }
}