namespace DesignPattern.Behavioural.Mediator;

public class MediatorClient
{
    public static void Invoke()
    {
        var messenger = new MessengerGroupMediator();
        var jim = new User(messenger, "Jim");
        var adam = new User(messenger, "Adam");
        var jessica = new User(messenger, "Jessica");

        messenger.Register(jim);
        messenger.Register(adam);
        messenger.Register(jessica);

        jim.Send("hey everyone, how are you");
        jessica.Send("hey there, we are good");
    }
}

