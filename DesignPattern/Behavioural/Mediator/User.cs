namespace DesignPattern.Behavioural;

public class User : BaseUser
{
    public User(MessengerGroupMediator mediator, string name): base(mediator, name)
    {

    }

    public override void Deliver(string from, string message)
    {
        Console.WriteLine($"user {userName} received message \"{message}\" from {from}");
    }

    public override void Send(string message)
    {
        _mediator.Send(this, message);
    }
}