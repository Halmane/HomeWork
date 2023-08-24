namespace Monitor;

internal class ScreenSettings
{
    private static List<string> Language = new List<string>()
    {
        "Russian",
        "English",
        "Dutch",
        "Portugues",
        "French",
        "German"
    };
    private static List<string> ScreenResolution = new List<string>()
    {
        "1280x1024",
        "1366x768",
        "1600x900",
        "1920x1080",
        "3840x1080"
    };
    public bool IsLandspace { get; private set; }
    public string ActualScreenResolution { get; private set; }
    public string ActualLanguage { get; private set; }
    public int MaxFrameRate { get; private set; }
    public int Brightness { get; private set; }
    public int Contrast { get; private set; }
    private int _frameRate;
    public int FrameRate
    {
        get { return _frameRate; }
        private set
        {
            if (value > MaxFrameRate)
                _frameRate = MaxFrameRate;
            else if (value <= 0)
                _frameRate = 1;
            else
                _frameRate = value;
        }
    }

    public ScreenSettings(int maxFrameRate, int brightness, int contrast)
    {
        MaxFrameRate = maxFrameRate;
        Brightness = brightness;
        Contrast = contrast;
        FrameRate = maxFrameRate;
        ActualScreenResolution = ScreenResolution[0];
        ActualLanguage = Language[0];
        IsLandspace = true;
    }

    public void RotateScreen()
    {
        IsLandspace = !IsLandspace;
        Console.WriteLine(IsLandspace ? "Landspace" : "Portrait");
    }

    public void ChangeScreenResolution()
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
        } while (
            ActualScreenResolution != ScreenResolution.Find(p => p == ActualScreenResolution)
        );
    }

    public void ChangeFrameRate(int frameRate)
    {
        FrameRate = frameRate;
        Console.WriteLine($"Frame rate: {FrameRate}/{MaxFrameRate}");
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
    
    public void ChangeBrightness(Operation operation)
    {
        Brightness = operation == Operation.Plus ? ++Brightness : --Brightness;
        if (Brightness > 100)
            Brightness = 100;
        else if (Brightness <= 0)
            Brightness = 1;
        Console.WriteLine($"Brightness now: {Brightness}");
    }

    public void ChangeContrast(Operation operation)
    {
        Contrast = operation == Operation.Plus ? ++Contrast : --Contrast;
        if (Contrast > 100)
            Contrast = 100;
        else if (Contrast <= 0)
            Contrast = 1;
        Console.WriteLine($"Contrast now: {Contrast}");
    }
}
