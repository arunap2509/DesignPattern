namespace DesignPattern.Behavioural.Observer;

public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);
    void UnSubscribe(ISubscriber subscriber);
    void Notify();
}
