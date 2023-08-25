using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class DefaultConverter : ICurrencyConverter
    {
        public string CurrencyCode { get; private set; }
        public DefaultConverter(string code)
        {
            CurrencyCode = code;
        }

        public void ConvertRub(double value)
        {
            Console.WriteLine("Код не найден, введите курс:");
            var newConverter = Console.ReadLine();
            while (!double.TryParse(newConverter, out _) || double.Parse(newConverter) <= 0)
            {
                Console.WriteLine("Курс не верный,введите заново:");
                newConverter = Console.ReadLine();
            }
            Console.WriteLine($"{value} рублей = {value / double.Parse(newConverter)} {CurrencyCode}");
        }
    }
}
