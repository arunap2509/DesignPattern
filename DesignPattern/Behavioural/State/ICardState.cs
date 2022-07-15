namespace DesignPattern.Behavioural.State;

public interface ICardState
{
    void MoveToReadyToDev();
    void MoveToInDev();
    void MoveToTechReview();
    void MoveToReadyToTest();
    void MoveToInTesting();
    void MoveToClosed();
}
