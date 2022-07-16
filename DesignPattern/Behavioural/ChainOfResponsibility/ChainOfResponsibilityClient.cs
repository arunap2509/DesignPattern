namespace DesignPattern.Behavioural.ChainOfResponsibility;

public class ChainOfResponsibilityClient
{
    public static void Invoke()
    {
        var authenticationHandler = new AuthenticationHandler();
        authenticationHandler
            .SetNext(new CheckCookieHandler())
            .SetNext(new Resource());

        authenticationHandler
            .Handle(new Dictionary<string, object> { { "token", "abc$$" }, { "cookie", "hello" } });
    }
}

