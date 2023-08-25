namespace Converter;

public interface CurrencyConverter
{
    public string CurrencyCode { get; set; }
    public void ConvertRub(double value);
}
