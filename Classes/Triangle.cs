public class Triangle : Shape
{
    private decimal _base;
    private decimal _height;

    public Triangle(decimal @base, decimal height)
    {
        _base = @base;
        _height = height;
    }

    public override decimal GetArea() => Math.Round(((_base * _height) / 2), 2);
}