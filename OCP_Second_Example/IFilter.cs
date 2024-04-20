namespace OCP_Second_Example;

public interface IFilter<T>
{
    IList<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
}
