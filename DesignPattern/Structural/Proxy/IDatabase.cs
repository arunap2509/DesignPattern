namespace DesignPattern.Structural.Proxy;

// subject
public interface IDatabase
{
    bool Connect();
    void Write(string product, int count);
    int Read(string product);
    void Close();
}
