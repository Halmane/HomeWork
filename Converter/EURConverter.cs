namespace Converter;
public class EURConverter : ICurrencyConverter
{
    public string CurrencyCode { get; private set; }
    public EURConverter()
    {
        CurrencyCode = "EUR";
    }

    public void ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 102.4} {CurrencyCode}");
    }
}
