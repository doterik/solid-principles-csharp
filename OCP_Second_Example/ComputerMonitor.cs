namespace OCP_Second_Example;

public record ComputerMonitor(string Name, MonitorType Type, Screen Screen)
{
    public override string ToString() => $"Name: {Name}, Type: {Type}, Screen: {Screen}";
}
