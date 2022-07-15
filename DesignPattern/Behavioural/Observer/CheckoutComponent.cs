namespace DesignPattern.Behavioural.Observer;

public class CheckoutComponent : ISubscriber
{
    public void Update(IStoreState state)
    {
        Console.WriteLine($"checkout component received the count as {state.GetState()}");
    }
}
