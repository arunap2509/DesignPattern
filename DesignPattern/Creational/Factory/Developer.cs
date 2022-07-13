namespace DesignPattern.Creational.Factory;

public class Developer : IEmployee
{
    private readonly string _position;

    public Developer()
    {
        _position = EmployeeType.Developer.ToString();
    }

    public string GetPosition()
    {
        return _position;
    }
}
