#region Square

/*Console.Write("Enter the side of the square: ");
string? side = Console.ReadLine();

var square = new Square(Convert.ToInt32(side));

Console.WriteLine($"The area of the square is {square.GetArea()}");*/

#endregion

#region Rectangle

/*Console.Write("Enter the length of the rectangle: ");
string? length = Console.ReadLine();

Console.Write("Enter the width of the rectangle: ");
string? width = Console.ReadLine();

var rectangle = new Rectangle(Convert.ToDecimal(length), Convert.ToDecimal(width));

Console.WriteLine($"The area of the rectangle is {rectangle.GetArea()}");*/

#endregion

#region  Circle

/*Console.Write("Enter the diameter of the circle: ");
string? diameter = Console.ReadLine();
var circle = new Circle(Convert.ToInt32(diameter));
Console.WriteLine($"The area of the circle is {circle.GetArea()}");*/

#endregion

#region Triangle

Console.Write("Enter the base of the triangle: ");
string? _base = Console.ReadLine();
Console.Write("Enter the height of the triangle: ");
string? _height = Console.ReadLine();
var triangle = new Triangle(Convert.ToDecimal(_base), Convert.ToDecimal(_height));
Console.WriteLine($"area = {_base} * {_height} / 2 = {triangle.GetArea()}");

#endregion