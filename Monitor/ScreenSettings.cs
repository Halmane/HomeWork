﻿namespace Monitor;

internal class ScreenSettings
{
    private bool IsHorizontally = true;
    public List<string> ScreenResolution { get; private set; }
    private string ActualScreenResolution;
    private int _frameRate;
    public int FrameRate
    {
        get { return _frameRate; }
        private set
        {
            if (value > _maxFrameRate)
                _frameRate = _maxFrameRate;
            else if (value <= 0)
                _frameRate = 1;
            else
                _frameRate = value;
        }
    }
    public int _maxFrameRate { get; }
    public int Brightness;
    public int Contrast;
    public List<string> Language;
    public string ActualLanguage;

    public void RotateScreen()
    {
        IsHorizontally = !IsHorizontally;
        Console.WriteLine(IsHorizontally ? "Horizontally" : "Vertically");
    }

    public void ChangeScreenREsolution()
    {
        Console.Write("Select the resolution ");
        foreach (var resolution in ScreenResolution)
        {
            Console.Write($"{resolution}/");
        }
        Console.WriteLine(": ");
        do
        {
            ActualScreenResolution = Console.ReadLine();
        } while (ActualScreenResolution != ScreenResolution.Find(p => p == ActualScreenResolution));
    }

    public void ChangeFrameRate(int frameRate)
    {
        FrameRate = frameRate;
    }

    public void ChangeLanguage()
    {
        Console.Write("Select the language ");
        foreach (var language in Language)
        {
            Console.Write($"{language},");
        }
        Console.WriteLine(": ");
        do
        {
            ActualLanguage = Console.ReadLine();
        } while (ActualLanguage != Language.Find(p => p == ActualLanguage));
    }

    public void ChangeBrightness(char operation)
    {
        Brightness = operation == '+' ? Brightness++ : Brightness--;
        if (Brightness > 100)
            Brightness = 100;
        else if (Brightness <= 0)
            Brightness = 1;
        Console.WriteLine($"Brightness now: {Brightness}");
    }

    public void ChangeContrast(char operation)
    {
        Contrast = operation == '+' ? Contrast++ : Contrast--;
        if (Contrast > 100)
            Contrast = 100;
        else if (Contrast <= 0)
            Contrast = 1;
        Console.WriteLine($"Contrast now: {Contrast}");
    }
}
