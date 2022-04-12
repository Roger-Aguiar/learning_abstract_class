public class Circle : Shape
{
    private int diameter;

    public Circle(int diameter)
    {
        this.diameter = diameter;
    }

    public override decimal GetArea()
    {         
        return (decimal)Math.Round((Math.PI * Math.Pow(diameter, 2)), 2);        
    }
}