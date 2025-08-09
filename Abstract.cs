using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
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
        return Width * Height;
    }
}

class AbstractDemo
{
    static void Main(string[] args)
    {
        //abstract classes demo
        Shape circle = new Circle(5);      // radius = 5
        Shape rectangle = new Rectangle(4, 6); // width = 4, height = 6

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}