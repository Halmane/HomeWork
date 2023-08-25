namespace Converter;

public class Converters
{
    private List<CurrencyConverter> _converters = new() {new EURConverter(),new USDConverter() };

    public void Get(string code, double value)
    {
        var finder = _converters.Find(x => x.CurrencyCode == code);
        if (finder != null)
        {
            finder.ConvertRub(value);
            return;
        }
        Console.WriteLine("Такого кода нет!");
        return;
    }
}
