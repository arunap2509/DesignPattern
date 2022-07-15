namespace DesignPattern.Behavioural.TemplateMethod;

public class WoodenHouse : HousingTemplate
{
    public override void BuildFloor()
    {
        Console.WriteLine("Building wooden floor for the house");
    }

    public override void BuildWall()
    {
        Console.WriteLine("Building wooden walls for the house");
    }
}
