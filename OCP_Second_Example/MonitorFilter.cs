namespace OCP_Second_Example;

public class MonitorFilter : IFilter<ComputerMonitor>
{
    public IList<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        => monitors.Where(specification.IsSatisfied).ToList();
}
