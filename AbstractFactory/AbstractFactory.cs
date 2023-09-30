// Abstract Product
public interface Chair
{
    void SitOn();
}

// Concrete Products
public class ModernChair : Chair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair");
    }
}

public class VictorianChair : Chair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair");
    }
}

// Abstract Factory
public interface FurnitureFactory
{
    Chair CreateChair();
}

// Concrete Factories
public class ModernFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }
}

public class VictorianFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair()
    {
        return new VictorianChair();
    }
}