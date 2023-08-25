namespace Converter;

public interface ICurrencyConverter
{
    string CurrencyCode { get; }
    double ConvertRub(double value);
}
