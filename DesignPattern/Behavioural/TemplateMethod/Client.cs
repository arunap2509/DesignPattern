namespace DesignPattern.Behavioural.TemplateMethod;

public class TemplateMethodClient
{
    public static void Invoke()
    {
        HousingTemplate house = new WoodenHouse();

        house.Build();

        house = new StoneHouse();

        house.Build();
    }
}

