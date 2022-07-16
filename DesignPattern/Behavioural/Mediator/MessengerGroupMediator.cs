namespace DesignPattern.Behavioural;

public class MessengerGroupMediator : IChatRoomMediator
{
    private readonly List<User> _users;

    public MessengerGroupMediator()
    {
        _users = new();
    }

    public void Send(User from, string message)
    {
        foreach (var user in _users)
        {
            if (user == from) continue;

            user.Deliver(from.userName, message);
        }
    }

    public void Register(User user)
    {
        _users.Add(user);
    }
}
