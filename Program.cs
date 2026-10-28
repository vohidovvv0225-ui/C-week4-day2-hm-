// Student student = new Student();
// student.Greet();
// student.SetAge(21);
// student.ShowAge();
// student.Study();

// Teacher teacher = new Teacher();
// teacher.Greet();
// teacher.Explain();


Rectangle rectangle = new Rectangle("Red", 5, 3);
        Circle circle = new Circle("Blue", 4);

        Console.WriteLine("Rectangle created!");
        Console.WriteLine("Circle created!");
        Lamp lamp = new Lamp();
        lamp.TurnOn();
        lamp.ChangeBrightness(80);
        lamp.TurnOff();

        Thermostat thermostat = new Thermostat();
        thermostat.TurnOn();
        thermostat.SetTemperature(22);
        thermostat.TurnOff();

        Lock door = new Lock();
        door.TurnOn();
        door.LockDoor();
        door.TurnOff();