namespace Monitor;
internal class Connector
{
    public string Name;
    public Connector(string name)
    {
        Name = name;
    }

    public static Connector HDMI { get; } = new Connector("HDMI");
    public static Connector USB2_0 { get; } = new Connector("USB 2.0");
    public static Connector USB3_0 { get; } = new Connector("USB 3.0");
    public static Connector DisplayPort { get; } = new Connector("Display Port");
    public static Connector Jack3_5 { get; } = new Connector("Jack 3.5");
    public static Connector Type_C { get; } = new Connector("Type-C");
}
