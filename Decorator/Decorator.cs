// Component
public interface Coffee
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
public class Espresso : Coffee
{
    public string GetDescription()
    {
        return "Espresso";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

// Decorator
public abstract class CoffeeDecorator : Coffee
{
    protected Coffee coffee;

    public CoffeeDecorator(Coffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return coffee.GetCost();
    }
}

// Concrete Decorators
public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(Coffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} with Whipped Cream";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 0.5;
    }
}

public class CaramelDecorator : CoffeeDecorator
{
    public CaramelDecorator(Coffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} with Caramel";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 0.75;
    }
}