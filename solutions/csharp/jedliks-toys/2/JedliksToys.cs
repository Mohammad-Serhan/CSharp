class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _batteryPer = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryPer > 0){
            return $"Battery at {_batteryPer}%";
        }
        else {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (_batteryPer > 0){
            _metersDriven = _metersDriven + 20;
            _batteryPer = _batteryPer - 1;
        }
    }
}
