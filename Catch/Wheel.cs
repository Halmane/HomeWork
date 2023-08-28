namespace Catch;

public class Wheel
{

    public double Pressure { get; private set; }


    private void CheckPressure(double value)
    {
        if (value < 0 || value > 10)
            throw new IncorrectPressureException("Incorrect Pressure Exception");
        if (value > 2.5 && value <= 10)
            throw new TooHighPressureException("Too High Pressure Exception");
        if (value >= 0 && value < 1.6)
            throw new TooLowPressureException("Too Low Pressure Exception");
    }

    public void ChangePressure(double newPressure)
    {
        CheckPressure(newPressure);
        Pressure = newPressure;
    }

    public void PressureInfo()
    {
        CheckPressure(Pressure);
    }
}
