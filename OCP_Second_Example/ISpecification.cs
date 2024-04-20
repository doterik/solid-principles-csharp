namespace OCP_Second_Example;

public interface ISpecification<in T>
{
    bool IsSatisfied(T item);
}
