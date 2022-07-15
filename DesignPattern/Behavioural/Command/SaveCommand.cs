namespace DesignPattern.Behavioural.Command;

public class SaveCommand : ICommand<bool>
{
    private readonly DatabaseService _databaseService;
    private readonly string _product;
    private readonly int _count;

    public SaveCommand(DatabaseService databaseService, string product, int count)
    {
        _databaseService = databaseService;
        _product = product;
        _count = count;
    }

    public bool Execute()
    {
        return _databaseService.Save(_product, _count);
    }
}
