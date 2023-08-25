using Converter;
using System;



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
    if(Converters.Get(code) != null)
    {
        Converters.Get(code).ConvertRub(double.Parse(value));
        return;
    }
    Console.WriteLine("Код не найден, введите курс:");
    var newConverter = Console.ReadLine();
    while (!double.TryParse(newConverter, out _) || double.Parse(newConverter) <= 0)
    {
        Console.WriteLine("Курс не верный,введите заново:");
        newConverter = Console.ReadLine();
    }
    Console.WriteLine($"{value} рублей = {double.Parse(value) / double.Parse(newConverter)} {code}");
}