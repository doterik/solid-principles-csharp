/* https://code-maze.com/open-closed-principle */

using OCP_Second_Example;

var monitors = new List<ComputerMonitor>
{
    new("Samsung S345", MonitorType.OLED, Screen.CurvedScreen),
    new("Philips P532", MonitorType.LCD, Screen.WideScreen),
    new("LG L888", MonitorType.LED, Screen.WideScreen),
    new("Samsung S999", MonitorType.OLED, Screen.WideScreen),
    new("Dell D2J47", MonitorType.LCD, Screen.CurvedScreen)
};

var filter = new MonitorFilter();

var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
Console.WriteLine("All LCD monitors");
foreach (var monitor in lcdMonitors) Console.WriteLine(monitor.ToString());

var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
Console.WriteLine("All WideScreen Monitors");
foreach (var monitor in wideScreenMonitors) Console.WriteLine(monitor.ToString());
