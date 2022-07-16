namespace DesignPattern.Behavioural.ChainOfResponsibility;

public class AuthenticationHandler : BaseHandler
{
    public override void Handle(Dictionary<string, object> context)
    {
        if (context.ContainsKey("token") && ValidateToken(context["token"] as string))
        {
            Console.WriteLine("authentication done, calling next");

            _context = context;

            Next();

            Console.WriteLine("returning from authentication handler");

            return;
        }

        Console.WriteLine("authentication failed, returning");
    }

    private static bool ValidateToken(string token)
    {
        if (token == "abc$$")
        {
            return true;
        }

        return false;
    }
}
