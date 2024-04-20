#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace OCP_First_Example;

public class SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
{
    private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation = developerCalculation;

    public double CalculateTotalSalaries()
    {
        var totalSalaries = 0D;

        foreach (var devCalc in _developerCalculation)
        {
            totalSalaries += devCalc.CalculateSalary();
        }

        return totalSalaries;
    }
}
