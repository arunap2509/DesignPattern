namespace DesignPattern.Behavioural.Iterator;

public class ListCollection<T> : IIterable<T>
{
    private readonly List<T> _collection;

    public ListCollection()
    {
        _collection = new();
    }

    public void Add(T item)
    {
        _collection.Add(item);
    }

    public IIterator<T> GetIterator()
    {
        return new ListIterator<T>(_collection);
    }
}
