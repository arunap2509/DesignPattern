namespace DesignPattern.Behavioural.Command;

public class Application
{
    public T ExecuteCommand<T>(ICommand<T> command)
    {
        return command.Execute();
    }
}