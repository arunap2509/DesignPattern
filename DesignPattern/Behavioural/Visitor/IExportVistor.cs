namespace DesignPattern.Behavioural.Visitor;

public interface IExportVistor
{
    void Export(ResidentialHouse residentialHouse);
    void Export(Hospital hospital);
    void Export(Industries industries);
}