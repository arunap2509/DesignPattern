namespace DesignPattern.Behavioural.Command;

public class CommandClient
{
    public static void Invoke()
    {
        Application application = new();
        DatabaseService databaseService = new();

        var saveCommand = new SaveCommand(databaseService, "keyboard", 20);
        application.ExecuteCommand(saveCommand);

        saveCommand = new SaveCommand(databaseService, "keyboard", 40);
        application.ExecuteCommand(saveCommand);

        var loadCommand = new LoadCommand(databaseService, "keyboard");
        Console.WriteLine(application.ExecuteCommand(loadCommand));

        var deleteCommand = new DeleteCommand(databaseService, "keyboard");
        application.ExecuteCommand(deleteCommand);

        var copyCommand = new CopyCommand();
        application.ExecuteCommand(copyCommand);
    }
}

