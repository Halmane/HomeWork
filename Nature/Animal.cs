namespace Nature;

internal class Animal
{
    private static int _energy;
    private static int _weight;
    private static int _currentAge;
    private static int _maximumAge;
    private static string _name;
    public static bool IsTooOld
    {
        get { return _currentAge >= _maximumAge ? true : false; }
    }

    public Animal(int energy, int weight, int currentAge, int maximumAge, string name)
    {
        _energy = energy;
        _weight = weight;
        _currentAge = currentAge;
        _maximumAge = maximumAge;
        _name = name;
    }

    public void Info()
    {
        Console.WriteLine(
            $"""
            Name: {_name}
            Weight: {_weight}
            Energy: {_energy}
            Current age: {_currentAge}
            """
        );
    }

    public static void Sleep()
    {
        _energy += 5;
        _currentAge += 1;
        Console.WriteLine($"{_name} is sleeping.");
    }

    public static void Eat()
    {
        _energy += 3;
        _currentAge += Random.Shared.Next(0, 2);
        _weight += 1;
        Console.WriteLine($"{_name} is eating.");
    }

    public static void Move()
    {
        _energy -= 5;
        _currentAge += Random.Shared.Next(0, 2);
        _weight -= 1;
        Console.WriteLine($"{_name} is moving.");
    }

    public void Birth(List<Animal> Animals)
    {
        var animal = new Animal(
            Random.Shared.Next(1, 10),
            Random.Shared.Next(1, 5),
            1,
            _maximumAge,
            _name
        );
        Animals.Add(animal);
        Console.WriteLine("A new animal was born!");
        animal.Info();
    }

    public static void TryAction(Action action)
    {
        if (IsTooOld)
            return;
        if (action == Sleep)
            action();
        else if (action == Eat)
            action();
        else if (action == Move && _energy > 6 && _weight > 2)
            action();
    }

    private void TryIncrementAge()
    {
        if (Random.Shared.Next(0, 100) <= 10)
            _currentAge++;
    }
}
