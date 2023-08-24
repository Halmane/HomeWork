using System.Xml.Linq;

namespace Nature;

public class Animal
{
    public int Energy { get; protected set; }
    public int Weight { get; protected set; }
    public int CurrentAge { get; protected set; }
    public int MaximumAge { get; protected set; }
    public string Name { get; protected set; }
    public bool IsTooOld
    {
        get { return CurrentAge >= MaximumAge ? true : false; }
    }

    private static List<string> _nameForAnimal = new List<string>() { "Bob", "Pop", "Tot", "Gog" };

    public Animal()
    {
        Energy = Random.Shared.Next(1, 20);
        Weight = Random.Shared.Next(1, 20);
        CurrentAge = Random.Shared.Next(1, 15);
        MaximumAge = Random.Shared.Next(15, 20);
        Name = _nameForAnimal[Random.Shared.Next(0, _nameForAnimal.Count - 1)];
    }

    public Animal(int energy, int weight, int currentAge, int maximumAge, string name)
    {
        Energy = energy;
        Weight = weight;
        CurrentAge = currentAge;
        MaximumAge = maximumAge;
        Name = name;
    }

    public void Info()
    {
        Console.WriteLine(
            $"""
            Name: {Name}
            Weight: {Weight}
            Energy: {Energy}
            Current age: {CurrentAge}
            """
        );
    }

    public void Sleep()
    {
        Energy += 5;
        CurrentAge += 1;
        Console.WriteLine($"{Name} is sleeping.");
    }

    public void Eat()
    {
        Energy += 3;
        CurrentAge += Random.Shared.Next(0, 2);
        Weight += 1;
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual bool Move()
    {
        if (IsTooOld)
            return false;
        Energy -= 5;
        CurrentAge += Random.Shared.Next(0, 2);
        Weight -= 1;
        Console.WriteLine($"{Name} is moving.");
        return true;
    }

    public virtual Animal Birth(Animal mother)
    {
        var animal = new Animal(
            Random.Shared.Next(1, 10),
            Random.Shared.Next(1, 5),
            1,
            mother.MaximumAge,
            mother.Name
        );
        Console.WriteLine("A new animal was born!");
        animal.Info();
        return animal;
    }

    private void TryIncrementAge()
    {
        if (Random.Shared.Next(0, 100) <= 10)
            CurrentAge++;
    }
}
