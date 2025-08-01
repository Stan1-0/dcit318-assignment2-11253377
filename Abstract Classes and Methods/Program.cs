﻿abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius; // Area of circle = πr²
    }
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height; // Area of rectangle = width × height
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances
        Circle circle = new Circle(5); // Radius = 5
        Rectangle rectangle = new Rectangle(4, 6); // Width = 4, Height = 6

        // Display areas
        Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}");
    }
}
