namespace Catch;

internal class TooLowPressureException : Exception
{
    public TooLowPressureException(double pressure) : base($"Too Low Pressure Exception : {pressure}") { }
}