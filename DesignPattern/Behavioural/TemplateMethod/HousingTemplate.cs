namespace DesignPattern.Behavioural.TemplateMethod;

public abstract class HousingTemplate
{
    public void Build()
    {
        BuildFoundation();
        BuildWall();
        BuildWindow();
        BuildFloor();
        BuildRoof();

        Console.WriteLine("House construction completed");
    }

    private void BuildFoundation()
    {
        Console.WriteLine("Building the foundation for the house");
    }

    public abstract void BuildWall();

    public abstract void BuildFloor();

    public virtual void BuildWindow()
    {
        Console.WriteLine("Building windows for the house");
    }

    public virtual void BuildRoof()
    {
        Console.WriteLine("Building roof for the house");
    }
}
