namespace DesignPattern.Behavioural.ChainOfResponsibility;

public abstract class BaseHandler : IHandler
{
    private IHandler _handler;
    protected Dictionary<string, object> _context;

    public abstract void Handle(Dictionary<string, object> context);

    public void Next()
    {
        if (_handler != null)
        {
            _handler.Handle(_context);
        }
    }

    public IHandler SetNext(IHandler handler)
    {
        _handler = handler;

        return _handler;
    }
}
