namespace DesignPattern.Behavioural.State;

public class StateClient
{
    public static void Invoke()
    {
        var jiraBoard = new JiraBoard();

        var homePageCard = jiraBoard.CreateCard("Home Page");

        homePageCard.MoveToClosed();
        homePageCard.MoveToReadyToDev();
        homePageCard.MoveToInDev();
        homePageCard.MoveToTechReview();
        homePageCard.MoveToInTesting();
        homePageCard.MoveToReadyToTest();
        homePageCard.MoveToClosed();

        homePageCard.CurrentState();

        var detailPageCard = jiraBoard.CreateCard("Detail Page");
        detailPageCard.MoveToInDev();

        detailPageCard.CurrentState();

        var checkoutPageCard = jiraBoard.CreateCard("Checkout Page");
        checkoutPageCard.MoveToInDev();

        checkoutPageCard.CurrentState();

        var checkoutCard = jiraBoard.GetCard("Checkout Page");

        checkoutCard.MoveToInDev();
        checkoutCard.MoveToTechReview();
        checkoutCard.MoveToInTesting();

        checkoutCard.CurrentState();
        checkoutPageCard.CurrentState();
    }
}

