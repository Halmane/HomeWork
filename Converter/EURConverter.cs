namespace Converter;
public class EURConverter : CurrencyConverter
{
    public string CurrencyCode { get; set; }
    public EURConverter()
    {
        CurrencyCode = "EUR";
    }

    public void ConvertRub(double value)
    {
        Console.WriteLine($"{value} рублей = {value / 102.4} {CurrencyCode}");
    }
}
