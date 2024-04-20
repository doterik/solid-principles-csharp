#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace OCP_Second_Example;

public class MonitorTypeSpecification(MonitorType type) : ISpecification<ComputerMonitor>
{
    private readonly MonitorType _type = type;

    public bool IsSatisfied(ComputerMonitor item) => item.Type == _type;
}
