using System;

namespace Converter;

public static class Converters
{
    private static List<CurrencyConverter> _converters = new() { new EURConverter(), new USDConverter() };

    public static CurrencyConverter Get(string code)
    {
        var finder = _converters.Find(x => x.CurrencyCode == code);
        if (finder != null)
        {
            return finder;
        }
        
        return null;
    }
}