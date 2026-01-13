Animal animal = new Animal { Name = "Animals"};
animal.Eat();

Dog dog = new();
dog.Name = "doggo";
dog.Eat();
dog.Bark();

public class Animal
{
    public string Name;
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}
