namespace Converter;

public class USDConverter : ICurrencyConverter
{
    public string CurrencyCode { get;}
    public USDConverter()
    {
        CurrencyCode = "USD";
    }

    public double ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 94.4} {CurrencyCode}");
        return value / 94.4;
    }
}
