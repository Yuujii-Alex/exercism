class RemoteControlCar
{
    private int speed;
    private int distanceDriven = 0;
    private int battery = 100;
    private int batteryDrain;


    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (battery < batteryDrain) return;

        distanceDriven += speed;
        battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
    
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() <= distance)
        {
            car.Drive();
        }

        return car.DistanceDriven() >= distance;
    }
}
