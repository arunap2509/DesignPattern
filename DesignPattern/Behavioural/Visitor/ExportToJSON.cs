namespace DesignPattern.Behavioural.Visitor;

public class ExportToJSON : IExportVistor
{
    public void Export(ResidentialHouse residentialHouse)
    {
        Console.WriteLine("residetial houses are exported as json");
    }

    public void Export(Hospital hospital)
    {
        Console.WriteLine("hospitals are exported as json");
    }

    public void Export(Industries industries)
    {
        Console.WriteLine("industries are exported as json");
    }
}

