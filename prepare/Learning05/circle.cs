public class Circle : Shape
{
    private Double _radius = 0;

    //----------------------------

    public Circle(String color, Double radius) : base(color)
    {
        _radius = radius;
    }

    //-------------------------------------

    public override double GetArea()
    {
        Double area = 3.14159265358979 * (_radius * _radius);
        return area;
    }
}