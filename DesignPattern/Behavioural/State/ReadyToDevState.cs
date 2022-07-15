namespace DesignPattern.Behavioural.State;

public class ReadyToDevState : ICardState
{
    private readonly TaskCard _taskCard;

    public ReadyToDevState(TaskCard taskCard)
    {
        _taskCard = taskCard;
    }

    public void MoveToClosed()
    {
        Console.WriteLine("Cannot move the card to closed as dev and testing are not done");
    }

    public void MoveToInDev()
    {
        _taskCard.ChangeState(new InDevState(_taskCard));
        Console.WriteLine("moved the card to in dev state");
    }

    public void MoveToInTesting()
    {
        Console.WriteLine("Cannot move the card to in testing as devlopment is not done");
    }

    public void MoveToReadyToDev()
    {
        Console.WriteLine("Card is already in ready to dev, no change needed");
    }

    public void MoveToReadyToTest()
    {
        Console.WriteLine("Cannot move the card to ready to testing as devlopment is not done");
    }

    public void MoveToTechReview()
    {
        Console.WriteLine("Cannot move the card to tech review as devlopment is not done");
    }
}
