namespace DesignPattern.Behavioural.Command;

public class DeleteCommand : ICommand<bool>
{
    private readonly DatabaseService _databaseService;
    private readonly string _product;

    public DeleteCommand(DatabaseService databaseService, string product)
    {
        _databaseService = databaseService;
        _product = product;
    }

    public bool Execute()
    {
        return _databaseService.Delete(_product);
    }
}
