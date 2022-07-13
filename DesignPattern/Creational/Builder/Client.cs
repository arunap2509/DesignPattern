namespace DesignPattern.Creational.Builder;

public class BuilderClient
{
    public static void Invoke()
    {
        // create house using a director, can be used when the user dont want to customize

        var houseBuilder = new StoneHouseBuilder();
        var director = new HouseBuilderDirector(houseBuilder);
        var normalHouse = director.BuildNormalHouse();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        normalHouse.ListParts();


        // user can build our own house, when they want to customize
        var woodenHouseBuilder = new WoodenHouseBuilder();

        var woodenHouse = woodenHouseBuilder
                            .AddRoomWithDoor()
                            .AddRoomWithDoor()
                            .AddRoomWithDoor()
                            .AddRoomWithDoor()
                            .AddLawn()
                            .AddGarage()
                            .AddSwimmingPool()
                            .AddStoreRoom()
                            .Build();

        Console.BackgroundColor = ConsoleColor.DarkYellow;
        woodenHouse.ListParts();

        woodenHouseBuilder.Reset();

        var anotherWoodenHouse = woodenHouseBuilder
                                    .AddRoomWithDoor()
                                    .AddRoomWithDoor()
                                    .AddLawn()
                                    .AddSwimmingPool()
                                    .Build();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        anotherWoodenHouse.ListParts();
    }
}