public class Rectangle : Shape
{
    private decimal length;
    private decimal width;

    public Rectangle(decimal length, decimal width)
    {
        if (length == width)
        {
            Console.WriteLine("This is not a rectangle, please, try again!");
        }
        else
        {
            this.length = length;
            this.width = width;
        }
    }

    public override decimal GetArea() => length * width;
}