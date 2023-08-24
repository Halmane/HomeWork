namespace Monitor;

internal class Screen
{
    public string Brand { get; }
    public string Model { get; }
    public double Diagonal { get; }
    public string Matrix;
    public bool Curved;
    public bool IsOn = false;
    public List<(Connector, int count)> Connectors;
    public ScreenSettings ScreenSettings;

    public Screen(string brand, string model, double diagonal, string matrix, bool curved)
    {
        ScreenSettings = new ScreenSettings(120, 100, 100);
        Connectors = new List<(Connector, int count)>()
        {
            (Connector.HDMI, 1),
            (Connector.USB2_0, 1),
            (Connector.USB3_0, 2),
            (Connector.Jack3_5, 1),
            (Connector.DisplayPort, 1),
            (Connector.Type_C, 3)
        };
        Brand = brand;
        Model = model;
        Diagonal = diagonal;
        Matrix = matrix;
        Curved = curved;
        ScreenInfo();
    }

    public void ScreenOn()
    {
        IsOn = !IsOn;
        if (IsOn)
        {
            Console.WriteLine("Connection Search");
            Thread.Sleep(5000);
        }
        Console.WriteLine(IsOn ? "Screen On" : "Screen Off");
    }

    public void ScreenInfo()
    {
        Console.Write(
            $"Brand: {Brand} " +
            $"\nModel: {Model} " +
            $"\nDiagonal: {Diagonal} " +
            $"\nMatrix: {Matrix} " +
            $"\nCurved: {Curved} " +
            $"\nLanguage: {ScreenSettings.ActualLanguage} " +
            $"\nFrame rate: {ScreenSettings.FrameRate}/{ScreenSettings._maxFrameRate}" +
            $"\nBrightness: {ScreenSettings.Brightness} Contrast: {ScreenSettings.Contrast}" +
            $"\nOrientation: "
        );
        Console.WriteLine(ScreenSettings.IsLandspace? "Landspace": "Portrait");
    }
}
