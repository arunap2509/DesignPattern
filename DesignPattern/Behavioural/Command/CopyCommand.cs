namespace DesignPattern.Behavioural.Command;

public class CopyCommand : ICommand<bool>
{
    public bool Execute()
    {
        Console.WriteLine("Copied command");
        return true;
    }
}
