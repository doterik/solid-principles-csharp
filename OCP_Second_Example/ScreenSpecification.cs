#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace OCP_Second_Example;

public class ScreenSpecification(Screen screen) : ISpecification<ComputerMonitor>
{
    private readonly Screen _screen = screen;

    public bool IsSatisfied(ComputerMonitor item) => item.Screen == _screen;
}
