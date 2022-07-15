namespace DesignPattern.Behavioural.Command;

public interface ICommand<TReturn>
{
    TReturn Execute();
}