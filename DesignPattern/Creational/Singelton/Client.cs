namespace DesignPattern.Creational.Singelton;

public class SingeltonClient
{
    public static void Invoke()
    {
        var instance1 = Database.GetInstance();
        var instance2 = Database.GetInstance();

        if (instance1 == instance2)
        {
            Console.WriteLine("Same instance");
        }

        instance1.Connect();
    }
}