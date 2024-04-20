namespace OCP_First_Example;

public class JuniorDevSalaryCalculator(DeveloperReport developerReport) : BaseSalaryCalculator(developerReport)
{
    public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
}
