namespace Converter;

public class USDConverter : ICurrencyConverter
{
    public string CurrencyCode { get; private set; }
    public USDConverter()
    {
        CurrencyCode = "USD";
    }

    public void ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 94,4} {CurrencyCode}");
    }
}
