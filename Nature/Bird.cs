namespace Nature;

public class Bird : Animal
{
    public Bird(int energy, int weight, int currentAge, int maximumAge, string name)
        : base(energy, weight, currentAge, maximumAge, name) { }

    public Bird()
        : base() { }

    public override bool Move()
    {
        if (base.Move())
        {
            Console.WriteLine($"{Name} is flying.");
            return true;
        }
        return false;
    }

    public override Animal Birth(Animal mother)
    {
        var animal = new Bird(
            Random.Shared.Next(1, 10),
            Random.Shared.Next(1, 5),
            1,
            mother.MaximumAge,
            mother.Name
        );
        Console.WriteLine("A new bird was born!");
        animal.Info();
        return animal;
    }
}
