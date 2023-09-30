// Model
public class Restaurant
{
    public string PrepareFood(string order)
    {
        return $"Cooked {order}...";
    }
}

// View
public class CustomerView
{
    public void DisplayFood(string food)
    {
        Console.WriteLine($"Serving: {food}");
    }
}

// Controller
public class WaitstaffController
{
    private Restaurant restaurant;
    private CustomerView customerView;

    public WaitstaffController(Restaurant restaurant, CustomerView customerView)
    {
        this.restaurant = restaurant;
        this.customerView = customerView;
    }

    public void TakeOrder(string order)
    {
        string food = restaurant.PrepareFood(order);
        customerView.DisplayFood(food);
    }
}