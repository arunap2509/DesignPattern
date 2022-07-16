namespace DesignPattern.Behavioural;

public abstract class BaseUser
{
    protected readonly MessengerGroupMediator _mediator;
    public readonly string userName;

    public BaseUser(MessengerGroupMediator mediator, string name)
    {
        _mediator = mediator;
        userName = name;
    }

    public abstract void Send(string message);
    public abstract void Deliver(string from, string message);
}
