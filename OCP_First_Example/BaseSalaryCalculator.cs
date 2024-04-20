namespace OCP_First_Example;

public abstract class BaseSalaryCalculator(DeveloperReport developerReport)
{
    protected DeveloperReport DeveloperReport { get; } = developerReport;

    public abstract double CalculateSalary();
}
