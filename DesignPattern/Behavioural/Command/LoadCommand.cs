namespace DesignPattern.Behavioural.Command;

public class LoadCommand : ICommand<int>
{
    private readonly DatabaseService _databaseService;
    private readonly string _product;

    public LoadCommand(DatabaseService databaseService, string product)
    {
        _databaseService = databaseService;
        _product = product;
    }

    public int Execute()
    {
        return _databaseService.Get(_product);
    }
}
