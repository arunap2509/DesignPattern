namespace DesignPattern.Behavioural.Visitor;

public class ExportToXML : IExportVistor
{
    public void Export(ResidentialHouse residentialHouse)
    {
        Console.WriteLine("residetial houses are exported as xml");
    }

    public void Export(Hospital hospital)
    {
        Console.WriteLine("hospitals are exported as xml");
    }

    public void Export(Industries industries)
    {
        Console.WriteLine("industries are exported as xml");
    }
}

