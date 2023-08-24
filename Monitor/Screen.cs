namespace Monitor;

internal class Screen
{
    public string Brand { get; }
    public string Model { get; }
    public double Diagonal { get; }
    public string Matrix { get; }
    public bool Curved { get; }
    public bool IsOn { get; private set; }
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
        IsOn = false;
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
            $"""
                Brand: {Brand}
                Model: {Model}
                Diagonal: {Diagonal}
                Matrix: {Matrix}
                Curved: {Curved}
                Language: {ScreenSettings.ActualLanguage}
                Frame rate: {ScreenSettings.FrameRate}/{ScreenSettings.MaxFrameRate}
                Brightness: {ScreenSettings.Brightness} Contrast: {ScreenSettings.Contrast}
                Orientation: 
            """
        );
        Console.WriteLine(ScreenSettings.IsLandspace ? "Landspace" : "Portrait");
    }
}
