namespace DesignPattern.Behavioural.State;

public class ReadyToTestState: ICardState
{
    private readonly TaskCard _taskCard;

    public ReadyToTestState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        Console.WriteLine("cannot move the card to closed as testing is not done yet");
    }

    public void MoveToInDev()
    {
        _taskCard.ChangeState(new InDevState(_taskCard));
        Console.WriteLine("moved the card back to in dev");
    }

    public void MoveToInTesting()
    {
        _taskCard.ChangeState(new InTestingState(_taskCard));
        Console.WriteLine("moved the card to in testing state");
    }

    public void MoveToReadyToDev()
    {
        _taskCard.ChangeState(new ReadyToDevState(_taskCard));
        Console.WriteLine("moved the card back to in ready to dev state");
    }

    public void MoveToReadyToTest()
    {
        Console.WriteLine("card is already in ready to test state, no change needed");
    }

    public void MoveToTechReview()
    {
        Console.WriteLine("cannot move the card to tech review as the review is done");
    }
}
