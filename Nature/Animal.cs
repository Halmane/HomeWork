namespace Nature;

internal class Animal
{
    private static int _energy;
    private int _weight;
    private static int _currentAge;
    private int _maximumAge;
    private static int _name;
    public static bool IsTooOld
    {
        get { return _currentAge >= _maximumAge ? true : false; }
    }

    public Animal(int energy, int weight, int currentAge, int maximumAge, int name)
    {
        _energy = energy;
        _weight = weight;
        _currentAge = currentAge;
        _maximumAge = maximumAge;
        _name = name;
    }

    public static void Sleep()
    {
        _energy += 5;
        _currentAge += 1;
        Console.WriteLine($"{_name} is sleeping.");
    }

    public void Eat()
    {
        _energy += 3;
        _currentAge += Random.Shared.Next(0,2);
        _weight += 1;
        Console.WriteLine($"{_name} is eating.");
    }
    public void Move()
    {
        _energy -= 5;
        _currentAge += Random.Shared.Next(0, 2);
        _weight -= 1;
        Console.WriteLine($"{_name} is moving.");
    }

    public static void TryAction(Action action) 
    {
        if(action == Sleep) 
      
    }

    private void TryIncrementAge()
    {
        if (Random.Shared.Next(0, 100) <= 10) _currentAge++;
    }
}
