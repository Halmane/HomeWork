using System.Linq;

namespace Monitor;

internal class Screen : ScreenSettings
{
    public string Brand { get; }
    public string Model { get; }
    public double Diagonal { get; }
    public string Matrix;
    public bool Curved;
    public bool IsOn = false;
    public Dictionary<string, int> Connectors;
    

    public void MonitorOn()
    {
        IsOn = !IsOn;
        if (IsOn)
        {
            Console.WriteLine("Connection Search");
            Thread.Sleep(5000);
        }
        Console.WriteLine(IsOn ? "Screen On" : "Screen Off");
    }



    


}
