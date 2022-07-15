namespace DesignPattern.Behavioural.Stratergy;

public class StrategyClient
{
    public static void Invoke()
    {
        var parkingLot = new ParkingLot(new OfficeHourParkingStrategy());

        parkingLot.Park();

        parkingLot.ChangeStrategy(new NonPeakTimeParkingStrategy());

        parkingLot.Park();
    }
}

