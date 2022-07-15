namespace DesignPattern.Behavioural.State;

public class ClosedState: ICardState
{
    private readonly TaskCard _taskCard;

    public ClosedState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        Console.WriteLine("no changes needed as the card is already in closed state");
    }

    public void MoveToInDev()
    {
        _taskCard.ChangeState(new InDevState(_taskCard));
        Console.WriteLine("moving card back to in dev coz of some bug found while PO demo");
    }

    public void MoveToInTesting()
    {
        Console.WriteLine("cannot move the card back to intesting as testing is done");
    }

    public void MoveToReadyToDev()
    {
        _taskCard.ChangeState(new ReadyToDevState(_taskCard));
        Console.WriteLine("moving card back to ready to dev coz of some new requirements from clients");
    }

    public void MoveToReadyToTest()
    {
        Console.WriteLine("cannot move the card back to ready to test as testing is done");
    }

    public void MoveToTechReview()
    {
        Console.WriteLine("cannot move the card back to tech review as review is done");
    }
}