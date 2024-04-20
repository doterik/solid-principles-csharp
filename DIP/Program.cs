/* https://code-maze.com/dependency-inversion-principle */

using DIP;

var empManager = new EmployeeManager();
empManager.AddEmployee(new("Leen", Gender.Female, Position.Manager));
empManager.AddEmployee(new("Mike", Gender.Male, Position.Administrator));

var stats = new EmployeeStatistics(empManager);
Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
