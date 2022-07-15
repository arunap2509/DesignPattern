namespace DesignPattern.Behavioural.State;

public class JiraBoard
{
    private readonly List<TaskCard> _taskCards;

    public JiraBoard()
    {
        _taskCards = new();
    }

    public TaskCard CreateCard(string task)
    {
        var newCard = new TaskCard(task);
        _taskCards.Add(newCard);

        return newCard;
    }

    public TaskCard GetCard(string task)
    {
        return _taskCards.Find(card => card.task == task);
    }
}
