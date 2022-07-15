namespace DesignPattern.Behavioural.State;

public class InTestingState : ICardState
{
    private readonly TaskCard _taskCard;

    public InTestingState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        _taskCard.ChangeState(new ClosedState(_taskCard));
        Console.WriteLine("moving the card to closed state");
    }

    public void MoveToInDev()
    {
        _taskCard.ChangeState(new InDevState(_taskCard));
        Console.WriteLine("moving the card to in dev state coz of some bugs");
    }

    public void MoveToInTesting()
    {
        Console.WriteLine("card is already in intesting state, no changes");
    }

    public void MoveToReadyToDev()
    {
        _taskCard.ChangeState(new ReadyToDevState(_taskCard));
        Console.WriteLine("moving the card to ready to dev state coz of some requirement changes");
    }

    public void MoveToReadyToTest()
    {
        _taskCard.ChangeState(new ReadyToTestState(_taskCard));
        Console.WriteLine("moving the card back to ready to test state");
    }

    public void MoveToTechReview()
    {
        Console.WriteLine("cannot move the card back to tech review as review is done");
    }
}
