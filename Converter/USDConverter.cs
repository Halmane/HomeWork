namespace Converter;

public class USDConverter : CurrencyConverter
{
    public string CurrencyCode { get; set; }
    public USDConverter()
    {
        CurrencyCode = "USD";
    }

    public void ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 94,4} {CurrencyCode}");
    }
}
