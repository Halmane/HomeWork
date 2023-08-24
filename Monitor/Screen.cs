namespace Monitor;

internal class Screen
{
    public string Brand { get; }
    public string Model { get; }
    public double Diagonal { get; }
    public string Matrix { get; }
    public bool Curved { get; }
    public bool IsOn { get; private set; }
    public List<Connector> Connectors { get; }
    public ScreenSettings ScreenSettings { get; private set; }

    public Screen(string brand, string model, double diagonal, string matrix, bool curved)
    {
        ScreenSettings = new ScreenSettings(120, 100, 100);
        Connectors = new List<Connector>()
        {
            Connector.HDMI,
            Connector.USB2_0,
            Connector.USB3_0,
            Connector.Jack3_5,
            Connector.DisplayPort,
            Connector.Type_C,
            Connector.Type_C,
            Connector.Type_C,
            Connector.Type_C,
            Connector.USB3_0,
            Connector.USB3_0,
            Connector.USB3_0
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
        Console.WriteLine(
            $"""
                Brand: {Brand}
                Model: {Model}
                Diagonal: {Diagonal}
                Matrix: {Matrix}
                Curved: {Curved}
                Language: {ScreenSettings.ActualLanguage}
                Frame rate: {ScreenSettings.FrameRate}/{ScreenSettings.MaxFrameRate}
                Brightness: {ScreenSettings.Brightness} Contrast: {ScreenSettings.Contrast}
                Orientation: {(ScreenSettings.IsLandspace ? "Landspace" : "Portrait")}
            """
        );
    }
}
