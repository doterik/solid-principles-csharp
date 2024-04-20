/* https://code-maze.com/open-closed-principle */

using OCP_First_Example;

var devCalculations = new List<BaseSalaryCalculator>
{
    new SeniorDevSalaryCalculator(new(1, "Dev1", "Senior developer", 160, 30.5)),
    new JuniorDevSalaryCalculator(new(2, "Dev2", "Junior developer", 150, 20)),
    new SeniorDevSalaryCalculator(new(3, "Dev3", "Senior developer", 180, 30.5))
};

var calculator = new SalaryCalculator(devCalculations);
Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries():n} dollars");
