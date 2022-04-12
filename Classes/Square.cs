public class Square : Shape
{
    private int side;

    public Square(int side) => this.side = side;

    public override decimal GetArea() => (decimal)Math.Pow(side, 2);
}