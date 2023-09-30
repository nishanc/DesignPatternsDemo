﻿#region Singleton

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
// Coffee caramelCoffee = new CaramelDecorator(espresso);
// Coffee finalCoffee = new WhippedCreamDecorator(caramelCoffee);

// Console.WriteLine($"Description: {finalCoffee.GetDescription()}");
// Console.WriteLine($"Cost: ${finalCoffee.GetCost()}");

#endregion

#region Adapter

// EuropeanLaptop europeanLaptop = new EuropeanLaptop();
// IAmericanLaptop americanLaptop = new LaptopAdapter(europeanLaptop);

// americanLaptop.ChargeWithAmericanPlug();

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
IMessageService emailService = new EmailService();
MessageClient client = new MessageClient(emailService);

client.SendNotification("Hello, World!");

#endregion