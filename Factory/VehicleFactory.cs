public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Bike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Riding a bike");
    }
}

public class VehicleFactory
{
    public Vehicle CreateVehicle(string type)
    {
        if (type.ToLower() == "car")
            return new Car();
        else if (type.ToLower() == "bike")
            return new Bike();
        else
            throw new ArgumentException("Invalid vehicle type");
    }
}