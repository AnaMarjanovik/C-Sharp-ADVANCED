
using Task3.Entity;

Circle circle = new Circle(10);
Triangle triangle = new Triangle(5, 10, 15, 20);

Console.WriteLine("======== Circle ========");
Console.WriteLine($"L = {circle.CalculatePerimeter()}");
Console.WriteLine($"P = {circle.CalculateArea()}");

Console.WriteLine("======== Triangle ========");
Console.WriteLine($"P = {triangle.CalculateArea()}");
Console.WriteLine($"L = {triangle.CalculatePerimeter()}");


