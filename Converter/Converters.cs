namespace Converter;

public class Converters
{
    private List<CurrencyConverter> _converters = new() { new EURConverter(), new USDConverter() };

    public void Get(string code, double value)
    {
        var finder = _converters.Find(x => x.CurrencyCode == code);
        if (finder != null)
        {
            finder.ConvertRub(value);
            return;
        }
        Console.WriteLine("Код не найден, введите курс:");
        var newConverter = Console.ReadLine();
        while (!double.TryParse(newConverter, out _) || double.Parse(newConverter) <= 0)
        {
            Console.WriteLine("Курс не верный,введите заново:");
            newConverter = Console.ReadLine();
        }
        Console.WriteLine($"{value} рублей = {value / double.Parse(newConverter)} {code}");
    }
}