namespace DesignPattern.Behavioural.Observer;

public class ObserverClient
{
    public static void Invoke()
    {
        var store = new Store();

        var productComponent = new ProductDetailComponent();
        var cartComponent = new CartComponent();
        var checkoutCompoent = new CheckoutComponent();

        store.Subscribe(productComponent);
        store.Subscribe(checkoutCompoent);
        store.Subscribe(cartComponent);

        store.ChangeState(20);

        store.UnSubscribe(checkoutCompoent);

        store.ChangeState(50);
    }
}

