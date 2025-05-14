
using Task2.Entity;

Rectangle rectangle = new Rectangle(2, 10);
Circle circle = new Circle(7);
Triangle triangle = new Triangle(6, 4);

Console.WriteLine("Rectangle area: " + rectangle.GetAreaRectangle(2,10));
Console.WriteLine("Circle area: " + circle.GetAreaCircle(7));
Console.WriteLine("Triangle area: " + triangle.GetAreaTriangle(6,4));