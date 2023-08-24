namespace Nature;

public class Fish : Animal
{
    public Fish(int energy, int weight, int currentAge, int maximumAge, string name)
        : base(energy, weight, currentAge, maximumAge, name) { }

    public Fish()
        : base() { }

    public override bool Move()
    {
        if (base.Move())
        {
            Console.WriteLine($"{Name} is swimming.");
            return true;
        }
        return false;
    }

    public override Animal Birth(Animal mother)
    {
        var animal = new Fish(
            Random.Shared.Next(1, 10),
            Random.Shared.Next(1, 5),
            1,
            mother.MaximumAge,
            mother.Name
        );
        Console.WriteLine("A new fish was born!");
        animal.Info();
        return animal;
    }
}
