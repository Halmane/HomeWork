﻿namespace Converter;

public static class Converters
{
    private static List<ICurrencyConverter> _converters = new() { new EURConverter(), new USDConverter()};

    public static ICurrencyConverter Get(string code)
    {
        var finder = _converters.Find(x => x.CurrencyCode == code);
        if (finder != null)
        {
            return finder;
        }
        _converters.Add(new DefaultConverter(code));
        return _converters.Last();
    }
}