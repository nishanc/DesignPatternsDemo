// Existing Class (Adaptee)
public class EuropeanLaptop
{
    public void ChargeWithEuropeanPlug()
    {
        Console.WriteLine("Charging with European plug");
    }
}

// Target Interface
public interface IAmericanLaptop
{
    void ChargeWithAmericanPlug();
}

// Adapter
public class LaptopAdapter : IAmericanLaptop
{
    private EuropeanLaptop europeanLaptop;

    public LaptopAdapter(EuropeanLaptop europeanLaptop)
    {
        this.europeanLaptop = europeanLaptop;
    }

    public void ChargeWithAmericanPlug()
    {
        europeanLaptop.ChargeWithEuropeanPlug();
        Console.WriteLine("Adapter converted to American plug");
    }
}