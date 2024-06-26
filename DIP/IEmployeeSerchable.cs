﻿namespace DIP;

public interface IEmployeeSerchable
{
    IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
}
