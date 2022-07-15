namespace DesignPattern.Behavioural.Observer;

public interface ISubscriber
{
    void Update(IStoreState state);
}
