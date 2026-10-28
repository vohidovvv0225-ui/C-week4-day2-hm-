class Lamp : IDevice
{
    public void TurnOn() => Console.WriteLine("Lamp is on");

    public void TurnOff() => Console.WriteLine("Lamp is off");

    public void ChangeBrightness(int level)
    {
        Console.WriteLine($"Brightness: {level}%");
    }
}