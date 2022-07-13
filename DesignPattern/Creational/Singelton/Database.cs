namespace DesignPattern.Creational.Singelton;

public class Database
{
    private static readonly Database instance = new();

    private Database() { }

    public static Database GetInstance()
    {
        return instance;
    }

    public void Connect()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Connected to db");
    }
}