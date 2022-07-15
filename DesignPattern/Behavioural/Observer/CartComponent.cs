namespace DesignPattern.Behavioural.Observer;

public class CartComponent : ISubscriber
{
    public void Update(IStoreState state)
    {
        Console.WriteLine($"cart component received the count as {state.GetState()}");
    }
}