class RemoteControlCar
{
    private int speed;
    private int batteryDrainPer;
    private int nbOfMeters = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrainPer){
        this.speed = speed;
        this.batteryDrainPer = batteryDrainPer;
    }

    public bool BatteryDrained()
    {
        return ( battery <= 0 || battery < batteryDrainPer);
          
    }

    public int DistanceDriven()
    {
        return nbOfMeters;
    }

    public void Drive()
    {
        if (battery > 0 && battery >= batteryDrainPer) {
            nbOfMeters = nbOfMeters + speed;
            battery = battery - batteryDrainPer;
        }
    }

     public int GetBattery()
    {
        return batteryDrainPer;
    }
     public int GetSpeed()
    {
        return speed;
    }
    
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance ;

    public RaceTrack(int distance ) {
        this.distance  = distance ;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDrives = 100 / car.GetBattery();   // how many times car can drive
        int maxDistance = maxDrives * car.GetSpeed();     // total meters possible
        return maxDistance >= distance;
    }
}
