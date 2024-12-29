using System;

class Dog
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Bark()
    {
        Console.WriteLine($"{Name} says Woof!");
    }

    // Method to demonstrate object independence
    public void GrowOlder(int years)
    {
        Age += years;
        Console.WriteLine($"{Name} is now {Age} years old.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Dog
        Dog myDog = new Dog("Buddy", 5);
        Dog herDog = new Dog("Bella", 2);
        Dog neighbourDog = new Dog("Rex", 1);

        // Using the objects
        Console.WriteLine("Dogs barking:");
        myDog.Bark();
        herDog.Bark();
        neighbourDog.Bark();

        Console.WriteLine("\nAging dogs:");
        myDog.GrowOlder(2);
        herDog.GrowOlder(1);

        // Demonstrating they're separate objects
        Console.WriteLine("\nCheck ages after aging:");
        Console.WriteLine($"{myDog.Name} is {myDog.Age} years old.");
        Console.WriteLine($"{herDog.Name} is {herDog.Age} years old.");
        Console.WriteLine($"{neighbourDog.Name} is {neighbourDog.Age} years old.");

        // Wait for user input before closing
        Console.ReadLine();
    }
}