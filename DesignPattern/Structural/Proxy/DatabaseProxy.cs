namespace DesignPattern.Structural.Proxy;

// Proxy
public class DatabaseProxy : IDatabase
{
    private readonly Database _database;
    private readonly Dictionary<string, int> _cache; 

    public DatabaseProxy(Database database)
    {
        _database = database;
        _cache = new();
    }

    public void Close()
    {
        _database.Close();
    }

    public bool Connect()
    {
        if (HasAccess())
        {
            return _database.Connect();
        }

        return false;
    }

    private bool HasAccess()
    {
        var random = new Random();

        if (random.Next(1, 10) > 5)
        {
            Console.WriteLine("You dont have access to this database");
            return false;
        }

        Console.WriteLine("You have access to this database, connecting..");
        return true;
    }

    public int Read(string product)
    {
        if (_cache.ContainsKey(product))
        {
            Console.WriteLine("returning data from cache..");
            return _cache[product];
        }

        Console.WriteLine("reading data from database..");

        var count = _database.Read(product);
        _cache.Add(product, count);
        return count;
    }

    public void Write(string product, int count)
    {
        _cache.Clear();

        _database.Write(product, count);
    }
}