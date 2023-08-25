using Converter;



Convert();
Convert();


void Convert()
{
    Console.WriteLine("Введите код валюты:");
    string code = Console.ReadLine();
    Console.WriteLine("Введите сумму в рублях для конвертации:");
    var value = Console.ReadLine();
    while (!double.TryParse(value, out _) || double.Parse(value) <= 0)
    {
        Console.WriteLine("Неверная сумма денег, попробуйте снова:");
        value = Console.ReadLine();
    }
    Converters.Get(code).ConvertRub(double.Parse(value));
}