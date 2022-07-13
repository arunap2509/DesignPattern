namespace DesignPattern.Creational.Builder;

public class HouseBuilderDirector
{
    private readonly IHouseBuilder _houseBuilder;

    public HouseBuilderDirector(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public House BuildNormalHouse()
    {
        return _houseBuilder
            .AddRoomWithDoor()
            .AddRoomWithDoor()
            .AddRoomWithDoor()
            .AddGarage()
            .AddStoreRoom()
            .Build();
    }

    public House BuildSmallHouse()
    {
        return _houseBuilder
            .AddRoomWithDoor()
            .AddRoomWithDoor()
            .AddStoreRoom()
            .Build();
    }
}
