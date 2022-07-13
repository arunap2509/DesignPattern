namespace DesignPattern.Creational.Builder;

public class WoodenHouseBuilder : IHouseBuilder
{
    private readonly WoodenHouse _house;

    public WoodenHouseBuilder()
    {
        _house = new WoodenHouse();
    }

    public IHouseBuilder AddRoomWithDoor()
    {
        _house.AddParts("Room with door");
        return this;
    }

    public IHouseBuilder AddRoomWithoutDoor()
    {
        _house.AddParts("Room without door");
        return this;
    }

    public IHouseBuilder AddStoreRoom()
    {
        _house.AddParts("Store room");
        return this;
    }

    public IHouseBuilder AddGarage()
    {
        _house.AddParts("Garage");
        return this;
    }

    public IHouseBuilder AddLawn()
    {
        _house.AddParts("Lawn");
        return this;
    }

    public IHouseBuilder AddSwimmingPool()
    {
        _house.AddParts("Swimming Pool");
        return this;
    }

    public House Build()
    {
        return _house;
    }

    public void Reset()
    {
        _house.Reset();
    }
}
