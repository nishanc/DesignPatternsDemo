#region Singleton

President president1 = President.Instance;
President president2 = President.Instance;

Console.WriteLine($"Are both instances the same? : {president1 == president2}"); // true

#endregion

#region Factory

VehicleFactory factory = new VehicleFactory();
Vehicle vehicle1 = factory.CreateVehicle("car");
Vehicle vehicle2 = factory.CreateVehicle("bike");

vehicle1.Drive();
vehicle2.Drive();

#endregion