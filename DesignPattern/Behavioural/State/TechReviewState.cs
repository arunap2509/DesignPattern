namespace DesignPattern.Behavioural.State;

public class TechReviewState: ICardState
{
    private readonly TaskCard _taskCard;

    public TechReviewState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        Console.WriteLine("cannot the make the card as closed as testing is not done yet");
    }

    public void MoveToInDev()
    {
        _taskCard.ChangeState(new InDevState(_taskCard));
        Console.WriteLine("moved the card back to in dev state");
    }

    public void MoveToInTesting()
    {
        Console.WriteLine("cannot move the card to in testing as review is not done yet");
    }

    public void MoveToReadyToDev()
    {
        _taskCard.ChangeState(new ReadyToDevState(_taskCard));
        Console.WriteLine("moved the card back to ready to done");
    }

    public void MoveToReadyToTest()
    {
        _taskCard.ChangeState(new InTestingState(_taskCard));
        Console.WriteLine("moved the card to intesting state");
    }

    public void MoveToTechReview()
    {
        Console.WriteLine("card is already in tech review state");
    }
}
