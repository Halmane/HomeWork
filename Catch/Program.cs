using Catch;

var wheel = new Wheel();



try
{
    wheel.PressureInfo();
    wheel.ChangePressure(-10);
    wheel.ChangePressure(20);
    wheel.ChangePressure(9);
    wheel.ChangePressure(1);
    wheel.ChangePressure(2);
    wheel.PressureInfo();
}
catch (TooLowPressureException ex)
{
    Console.WriteLine(ex);
}
catch (TooHighPressureException ex)
{
    Console.WriteLine(ex);

}
catch (IncorrectPressureException ex)
{
    Console.WriteLine(ex);
}

