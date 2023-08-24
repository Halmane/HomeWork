namespace Nature;

public class Dog : Animal
{
    public Dog(int energy, int weight, int currentAge, int maximumAge, string name)
        : base(energy, weight, currentAge, maximumAge, name) { }

    public Dog()
        : base() { }

    public override bool Move()
    {
        if (base.Move())
        {
            Console.WriteLine($"{Name} is running.");
            return true;
        }
        return false;
    }

    public override Animal Birth(Animal mother)
    {
        var animal = new Dog(
            Random.Shared.Next(1, 10),
            Random.Shared.Next(1, 5),
            1,
            mother.MaximumAge,
            mother.Name
        );
        Console.WriteLine("A new dog was born!");
        animal.Info();
        return animal;
    }
}
