using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class InheritanceDemo
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow
    }
}