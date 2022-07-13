namespace DesignPattern.Creational.Builder;

public interface IHouseBuilder
{
    void Reset();
    House Build();
    IHouseBuilder AddRoomWithDoor();
    IHouseBuilder AddRoomWithoutDoor();
    IHouseBuilder AddStoreRoom();
    IHouseBuilder AddSwimmingPool();
    IHouseBuilder AddGarage();
    IHouseBuilder AddLawn();
}