namespace Game.Randomize;
public static class IntExtension
{
    public static bool Chance(this int value)
    {
        return Random.Shared.Next(1, 100) < value;
    }
}
