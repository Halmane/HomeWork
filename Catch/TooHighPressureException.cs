namespace Catch;

public class TooHighPressureException : Exception
{
    public TooHighPressureException(double pressure) : base($"Too High Pressure Exception : {pressure}") { }
}
