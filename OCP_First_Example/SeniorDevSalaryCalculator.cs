namespace OCP_First_Example;

public class SeniorDevSalaryCalculator(DeveloperReport developerReport) : BaseSalaryCalculator(developerReport)
{
    public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
}
