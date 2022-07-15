namespace DesignPattern.Behavioural.Observer;

public class Store : IPublisher, IStoreState
{
    private readonly List<ISubscriber> _subscribers;
    private int _state;

    public Store()
    {
        _subscribers = new();
        _state = 0;
    }

    public void ChangeState(int state)
    {
        _state = state;
        Notify();
    }

    public int GetState()
    {
        return _state;
    }

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void UnSubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(this);
        }
    }
}
