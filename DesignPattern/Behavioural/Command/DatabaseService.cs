namespace DesignPattern.Behavioural.Command;

public class DatabaseService
{
    private readonly Dictionary<string, int> _product;

    public DatabaseService()
    {
        _product = new();
    }

    public bool Save(string product, int count)
    {
        if (_product.ContainsKey(product))
        {
            _product[product] = count;
            Console.WriteLine($"Updated product: {product} count to {count}");
        }
        else
        {
            _product.Add(product, count);
            Console.WriteLine($"added product: {product} count to {count}");
        }

        return true;
    }

    public bool Delete(string product)
    {
        if (_product.ContainsKey(product))
        {
            _product.Remove(product);
            Console.WriteLine($"removed product: {product}");
            return true;
        }

        Console.WriteLine($"product: {product} dosent exist");
        return false;
    }

    public int Get(string product)
    {
        return _product.GetValueOrDefault(product);
    }
}
