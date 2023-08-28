namespace Catch;

[Serializable]
public class TooHighPressureException : Exception
{
    public TooHighPressureException(string massege) : base(massege) { }
}
