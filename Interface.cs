using System;

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Programme
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();      // Output: Car is moving
        bicycle.Move();  // Output: Bicycle is moving
    }
}
