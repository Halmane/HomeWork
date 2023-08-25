namespace Converter;
public class EURConverter : ICurrencyConverter
{
    public string CurrencyCode { get;}
    public EURConverter()
    {
        CurrencyCode = "EUR";
    }

    public double ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 102.4} {CurrencyCode}");
        return value / 102.4;
    }
}
