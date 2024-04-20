#pragma warning disable SA1309 // Field names should not begin with underscore.

namespace DIP;

public class EmployeeManager : IEmployeeSerchable
{
    private readonly List<Employee> _employees = [];

    public void AddEmployee(Employee employee) => _employees.Add(employee);

    public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
}
