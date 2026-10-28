class Thermostat : IDevice
{
    public void TurnOn() => Console.WriteLine("Thermostat is on");

    public void TurnOff() => Console.WriteLine("Thermostat is off");

    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"Temperature: {temperature} C");
    }
}