class RemoteControlCar
{
    private int _driven = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar(); 
    }

    public string DistanceDisplay() => "Driven " + _driven + " meters";

    public string BatteryDisplay() 
    {
        if(_battery == 0)
        {
            return "Battery empty";
        }
        return "Battery at " + _battery + "%";
    } 

    public void Drive()
    {
        if(_driven < 2000){
            _driven += 20;
            _battery -= 1;
        }
    }
}
