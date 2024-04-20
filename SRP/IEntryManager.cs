namespace SRP;

public interface IEntryManager<in T>
{
    void AddEntry(T entry);
    void RemoveEntryAt(int index);
}
