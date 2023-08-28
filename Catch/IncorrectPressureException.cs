namespace Catch;

internal class IncorrectPressureException : Exception
{
    public IncorrectPressureException(double pressure) : base($"Incorrect Pressure Exception : {pressure}") { }
}