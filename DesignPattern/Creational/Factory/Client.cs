namespace DesignPattern.Creational.Factory;

public class FactoryClient
{
    public static void Invoke()
    {
        var employee = EmployeeFactory.CreateEmployee(EmployeeType.Developer);
        Console.WriteLine(employee.GetPosition());
    }
}