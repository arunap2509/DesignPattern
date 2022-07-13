namespace DesignPattern.Creational.Factory;

public class Manager: IEmployee
{
    private readonly string _position;

    public Manager()
    {
        _position = EmployeeType.Manager.ToString();
    }

    public string GetPosition()
    {
        return _position;
    }
}
