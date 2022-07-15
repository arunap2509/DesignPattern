namespace DesignPattern.Behavioural.State;

public class InDevState : ICardState
{
    private readonly TaskCard _taskCard;

    public InDevState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        Console.WriteLine("Cannot move the card to closed as dev and testing are not done");
    }

    public void MoveToInDev()
    {
        Console.WriteLine("Card is already in in dev state, so no change needed");
    }

    public void MoveToInTesting()
    {
        Console.WriteLine("Cannot move the card to in testing as tech review is not done");
    }

    public void MoveToReadyToDev()
    {
        _taskCard.ChangeState(new ReadyToDevState(_taskCard));
        Console.WriteLine("moved the card back to ready to dev state");
    }

    public void MoveToReadyToTest()
    {
        Console.WriteLine("Cannot move the card to ready to testing as devlopment is not done");
    }

    public void MoveToTechReview()
    {
        _taskCard.ChangeState(new TechReviewState(_taskCard));
        Console.WriteLine("moved the card to tech review");
    }
}
