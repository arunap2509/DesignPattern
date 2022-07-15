namespace DesignPattern.Behavioural.Iterator;

public class ListIterator<T> : IIterator<T>
{
    private readonly List<T> _collection;
    private int _index;

    public ListIterator(List<T> collection)
    {
        _collection = collection;
        _index = 0;
    }

    public T Current()
    {
        return _collection[_index];
    }

    public bool HasMore()
    {
        return _collection.Count - 1 >= _index;
    }

    public void Next()
    {
        _index += 1;
    }
}