namespace DesignPattern.Behavioural.TemplateMethod;

public class StoneHouse : HousingTemplate
{
    public override void BuildFloor()
    {
        Console.WriteLine("Building stone floor for the house");
    }

    public override void BuildWall()
    {
        Console.WriteLine("Building stone walls for the house");
    }
}