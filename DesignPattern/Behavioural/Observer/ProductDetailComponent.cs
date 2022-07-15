namespace DesignPattern.Behavioural.Observer;

public class ProductDetailComponent : ISubscriber
{
    public void Update(IStoreState state)
    {
        Console.WriteLine($"Product detail component received the count as {state.GetState()}");
    }
}
