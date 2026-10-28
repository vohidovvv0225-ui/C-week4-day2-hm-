class Lock : IDevice
{
    public void TurnOn() => Console.WriteLine("Lock is locked");

    public void TurnOff() => Console.WriteLine("Lock is unlocked");

    public void LockDoor()
    {
        Console.WriteLine("Door locked");
    }
}

