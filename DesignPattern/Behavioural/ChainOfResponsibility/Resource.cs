namespace DesignPattern.Behavioural.ChainOfResponsibility;

public class Resource : BaseHandler
{
    public override void Handle(Dictionary<string, object> context)
    {
        Console.WriteLine("processing the resource");
    }
}