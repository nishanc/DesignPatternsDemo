// Product
public class Burger
{
    public string Bun { get; set; }
    public string Patty { get; set; }
    public List<string> Toppings { get; set; }
    public List<string> Condiments { get; set; }

    public void Display()
    {
        Console.WriteLine($"Bun: {Bun}, Patty: {Patty}");
        Console.WriteLine("Toppings: " + string.Join(", ", Toppings));
        Console.WriteLine("Condiments: " + string.Join(", ", Condiments));
    }
}

// Builder
public interface IBurgerBuilder
{
    void SetBun();
    void SetPatty();
    void SetToppings();
    void SetCondiments();
    Burger Build();
}

// Concrete Builder
public class DeluxeBurgerBuilder : IBurgerBuilder
{
    private Burger burger = new Burger();

    public void SetBun()
    {
        burger.Bun = "Sesame Seed Bun";
    }

    public void SetPatty()
    {
        burger.Patty = "Beef Patty";
    }

    public void SetToppings()
    {
        burger.Toppings = new List<string> { "Lettuce", "Tomato", "Onion", "Pickles" };
    }

    public void SetCondiments()
    {
        burger.Condiments = new List<string> { "Ketchup", "Mustard", "Mayonnaise" };
    }

    public Burger Build()
    {
        return burger;
    }
}

// Director
public class Waiter
{
    private IBurgerBuilder builder;

    public Waiter(IBurgerBuilder builder)
    {
        this.builder = builder;
    }

    public Burger Construct()
    {
        builder.SetBun();
        builder.SetPatty();
        builder.SetToppings();
        builder.SetCondiments();
        return builder.Build();
    }
}