namespace DesignPattern.Behavioural.Visitor;

public class Hospital
{
    private readonly string _streetName;
    private readonly string _hospitalName;
    private readonly (int x, int y) _coordinates;

    public Hospital(string streetName, string hospitalName, (int x, int y) coordinates)
    {
        _streetName = streetName;
        _hospitalName = hospitalName;
        _coordinates = coordinates;
    }

    public void Accept(IExportVistor vistor)
    {
        vistor.Export(this);
    }
}

