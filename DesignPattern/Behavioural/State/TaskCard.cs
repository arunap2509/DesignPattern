namespace DesignPattern.Behavioural.State;

public class TaskCard
{
    public readonly string task;
    private ICardState _cardState;

    public TaskCard(string taskName)
    {
        task = taskName;
        _cardState = new ReadyToDevState(this);
    }

    public void ChangeState(ICardState cardState)
    {
        _cardState = cardState;
    }

    public void CurrentState()
    {
        Console.WriteLine($"{task} card state: {_cardState.GetType()}");
    }

    public void MoveToReadyToDev()
    {
        _cardState.MoveToReadyToDev();   
    }

    public void MoveToInDev()
    {
        _cardState.MoveToInDev();
    }

    public void MoveToTechReview()
    {
        _cardState.MoveToTechReview();
    }

    public void MoveToReadyToTest()
    {
        _cardState.MoveToReadyToTest();
    }

    public void MoveToInTesting()
    {
        _cardState.MoveToInTesting();
    }

    public void MoveToClosed()
    {
        _cardState.MoveToClosed();
    }
}

