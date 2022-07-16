namespace DesignPattern.Behavioural.ChainOfResponsibility;

public interface IHandler
{
    void Handle(Dictionary<string, object> context);
    void Next();
    IHandler SetNext(IHandler handler);
}
