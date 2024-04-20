#pragma warning disable CA1822 // Mark members as static.

namespace SRP;

public class FileSaver
{
    public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> workReport)
    {
        _ = Directory.CreateDirectory(directoryPath); // No need for 'Directory.Exists()'.

        File.WriteAllText(Path.Combine(directoryPath, fileName), workReport.ToString());
    }
}
