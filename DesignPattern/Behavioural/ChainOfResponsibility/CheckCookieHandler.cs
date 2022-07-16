namespace DesignPattern.Behavioural.ChainOfResponsibility;

public class CheckCookieHandler : BaseHandler
{
    public override void Handle(Dictionary<string, object> context)
    {
        if (context.ContainsKey("cookie") && context["cookie"] as string == "hello")
        {
            Console.WriteLine("cookie verification done, calling next");

            _context = context;

            Next();

            Console.WriteLine("returning from cookie verification");

            return;
        }

        Console.WriteLine("cookie verification failed, returning");
    }
}
