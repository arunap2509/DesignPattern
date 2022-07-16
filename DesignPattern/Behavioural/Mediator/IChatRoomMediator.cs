namespace DesignPattern.Behavioural;

public interface IChatRoomMediator
{
    void Send(User from, string message);
    void Register(User user);
}
