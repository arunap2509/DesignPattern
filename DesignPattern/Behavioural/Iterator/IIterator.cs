namespace DesignPattern.Behavioural.Iterator;

public interface IIterator<T>
{
    bool HasMore();
    void Next();
    T Current();
}