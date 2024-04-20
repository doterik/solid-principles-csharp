namespace DIP;

public class EmployeeStatistics(IEmployeeSerchable emp)
{
    public int CountFemaleManagers()
        => emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
}
