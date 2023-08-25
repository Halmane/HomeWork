namespace Converter;

public interface ICurrencyConverter
{
    string CurrencyCode { get; }
    void ConvertRub(double value);
}
