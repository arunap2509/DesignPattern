namespace DesignPattern.Behavioural.Visitor;

public class VisitorClient
{
    public static void Invoke()
    {
        IExportVistor export = new ExportToJSON();

        ResidentialHouse residentialHouse = new("123 street", "austin house", (74, 110));
        residentialHouse.Accept(export);

        Industries industries = new("indus land", "modern optics", (44, 66));
        export = new ExportToXML();
        industries.Accept(export);
    }
}

