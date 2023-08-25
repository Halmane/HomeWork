using Converter;
using System;

var converter = new Converters();

convert(converter);
convert(converter);


void convert(Converters converter)
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
    converter.Get(code, double.Parse(value));
}