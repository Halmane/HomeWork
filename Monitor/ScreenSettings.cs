namespace Monitor;

internal class ScreenSettings
{
    public bool IsLandspace = true;
    private string _actualScreenResolution;
    public int _maxFrameRate { get; private set; }
    public int Brightness { get; private set; }
    public int Contrast { get; private set; }
    private static List<string> Language;
    public string ActualLanguage { get; private set; }
    private static List<string> ScreenResolution;
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

    public ScreenSettings(int maxFrameRate, int brightness, int contrast)
    {
        Language = new List<string>()
        {
            "Russian",
            "English",
            "Dutch",
            "Portugues",
            "French",
            "German"
        };
        ScreenResolution = new List<string>()
        {
            "1280x1024",
            "1366x768",
            "1600x900",
            "1920x1080",
            "3840x1080"
        };
        _maxFrameRate = maxFrameRate;
        Brightness = brightness;
        Contrast = contrast;
        FrameRate = maxFrameRate;
        _actualScreenResolution = ScreenResolution[0];
        ActualLanguage = Language[0];
    }

    public void RotateScreen()
    {
        IsLandspace = !IsLandspace;
        Console.WriteLine(IsLandspace ? "Landspace" : "Portrait");
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
            _actualScreenResolution = Console.ReadLine();
        } while (
            _actualScreenResolution != ScreenResolution.Find(p => p == _actualScreenResolution)
        );
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
