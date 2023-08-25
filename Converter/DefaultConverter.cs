namespace Converter;
public class DefaultConverter : ICurrencyConverter
{
    private double _exchangeRate;
    public string CurrencyCode { get;}
    public DefaultConverter(string code)
    {
        CurrencyCode = code;
    }

    public void ConvertRub(double value)
    {
        if(_exchangeRate<=0)
        {
            Console.WriteLine("Код не найден, введите курс:");
            var newConverter = Console.ReadLine();
            while (!double.TryParse(newConverter, out _) || double.Parse(newConverter) <= 0)
            {
                Console.WriteLine("Курс не верный,введите заново:");
                newConverter = Console.ReadLine();
            }
            _exchangeRate = double.Parse(newConverter);
        }
        Console.WriteLine($"{value} рублей = {value / _exchangeRate} {CurrencyCode}");
    }
}
