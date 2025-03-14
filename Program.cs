#region Singleton

// President president1 = President.Instance;
// President president2 = President.Instance;

// Console.WriteLine($"Are both instances the same? : {president1 == president2}"); // true

#endregion

#region Factory

// VehicleFactory factory = new VehicleFactory();
// Vehicle vehicle1 = factory.CreateVehicle("car");
// Vehicle vehicle2 = factory.CreateVehicle("bike");

// vehicle1.Drive();
// vehicle2.Drive();

#endregion

#region AbstractFactory

// FurnitureFactory absFactory = new ModernFurnitureFactory();
// Chair chair = absFactory.CreateChair();
// chair.SitOn();

#endregion

#region Builder

// IBurgerBuilder builder = new DeluxeBurgerBuilder();
// Waiter waiter = new Waiter(builder);
// Burger burger = waiter.Construct();

// burger.Display();

#endregion

#region AbstractBuilder

// ComputerBuilder absBuilder = new GamingComputerBuilder();
// ComputerAssembler assembler = new ComputerAssembler();
// Computer computer = assembler.Assemble(absBuilder);

// computer.Display();

#endregion

#region Decorator

// Coffee espresso = new Espresso();
// Console.WriteLine($"Description: {espresso.GetDescription()}");
// Console.WriteLine($"Cost: ${espresso.GetCost()}");

// Coffee caramelCoffee = new CaramelDecorator(espresso);
// Console.WriteLine($"Description: {caramelCoffee.GetDescription()}");
// Console.WriteLine($"Cost: ${caramelCoffee.GetCost()}");

// Coffee finalCoffee = new WhippedCreamDecorator(caramelCoffee);
// Console.WriteLine($"Description: {finalCoffee.GetDescription()}");
// Console.WriteLine($"Cost: ${finalCoffee.GetCost()}");

#endregion

#region Adapter

// EuropeanLaptop europeanLaptop = new EuropeanLaptop();
// IAmericanLaptop americanLaptop = new LaptopAdapter(europeanLaptop);

// americanLaptop.ChargeWithAmericanPlug();

#endregion

#region Strategy

// using DesignPatternsDemo.Strategy;

// List<int> numbers = [64, 25, 12, 22, 11];

// // Use Bubble Sort strategy
// Sorter sorter = new Sorter(new BubbleSort());
// sorter.SortNumbers(numbers);
// Console.WriteLine(string.Join(", ", numbers));

// // Change to Quick Sort strategy
// numbers = [64, 25, 12, 22, 11]; // Reset list

// sorter.SetStrategy(new QuickSort());

// sorter.SortNumbers(numbers);
// Console.WriteLine(string.Join(", ", numbers));

#endregion

#region Observer

// INewsPublisher newsAgency = new NewsAgency();
// INewsSubscriber subscriber1 = new NewsSubscriber("Subscriber 1");
// INewsSubscriber subscriber2 = new NewsSubscriber("Subscriber 2");

// newsAgency.AddSubscriber(subscriber1);
// newsAgency.AddSubscriber(subscriber2);

// newsAgency.NotifySubscribers("Breaking News: COVID-19 Update");

#endregion

#region MVC

// Restaurant restaurant = new Restaurant();
// CustomerView customerView = new CustomerView();
// WaitstaffController waitstaff = new WaitstaffController(restaurant, customerView);

// waitstaff.TakeOrder("Burger");

#endregion

#region Proxy

// IInternet internet = new InternetProxy();
// internet.ConnectTo("google.com");
// internet.ConnectTo("blocked.com");

#endregion

#region DependencyInjection

// Dependency Injection Container (e.g., Dependency Injection Framework)
// IMessageService emailService = new EmailService();
// MessageClient client = new MessageClient(emailService);

// client.SendNotification("Hello, World!");

#endregion

#region Demo

// using DesignPatternsDemo.Examples;
//
// Sorter sorter = new Sorter();
// List<int> numbers = new List<int> { 5, 3, 8, 1 };
//
// sorter.Sort(numbers, "BubbleSort");  // Outputs: Sorting using Quick Sort...
// Console.WriteLine(string.Join(", ", numbers));  // Outputs: 1, 3, 5, 8
#endregion