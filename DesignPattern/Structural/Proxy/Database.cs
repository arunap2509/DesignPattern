namespace DesignPattern.Structural.Proxy;

// real subject
public class Database : IDatabase
{
    private readonly Dictionary<string, int> _productInventory;

    public Database()
    {
        _productInventory = new Dictionary<string, int>
        {
            { "iPhone", 20 }, { "MacBook Pro", 5},  { "Surface Book", 10 }
        };
    }

    public void Close()
    {
        Console.WriteLine("Database connection closed");
    }

    public bool Connect()
    {
        Console.WriteLine("Connected to database");
        return true;
    }

    public int Read(string product)
    {
        if (_productInventory.ContainsKey(product))
        {
            return _productInventory[product];
        }

        return 0;
    }

    public void Write(string product, int count)
    {
        if (_productInventory.ContainsKey(product))
        {
            _productInventory[product] = count;
        }
        else
        {
            _productInventory.Add(product, count);
        }

        Console.WriteLine("Updated value into database");
    }
}