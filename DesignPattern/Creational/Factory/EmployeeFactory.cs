namespace DesignPattern.Creational.Factory;

public class EmployeeFactory
{
    public static IEmployee CreateEmployee(EmployeeType employeeType)
    {
        return employeeType switch
        {
            EmployeeType.Developer => new Developer(),
            EmployeeType.Manager => new Manager(),
            _ => throw new Exception()
        };
    }
}
