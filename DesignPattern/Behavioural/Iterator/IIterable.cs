namespace DesignPattern.Behavioural.Iterator;

public interface IIterable<T>
{
    IIterator<T> GetIterator();
}
