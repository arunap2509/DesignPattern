namespace DesignPattern.Structural.Proxy;

public class ProxyClient
{
    public static void Invoke()
    {
        var db = new Database();
        var proxyDb = new DatabaseProxy(db);

        var dbConnected = proxyDb.Connect();

        if (dbConnected)
        {
            proxyDb.Read("iPhone");
            proxyDb.Write("iPhone", 40);
            proxyDb.Read("iPhone");
            proxyDb.Read("iPhone");

            proxyDb.Close();
        }
    }
}