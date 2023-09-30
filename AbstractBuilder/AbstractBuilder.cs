// Abstract Builder
public abstract class ComputerBuilder
{
    protected Computer Computer { get; } = new Computer();

    public abstract void BuildCPU();
    public abstract void BuildRAM();
    public abstract void BuildStorage();
    public Computer GetComputer() => Computer;
}

// Product
public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}");
    }
}

// Concrete Builders
public class GamingComputerBuilder : ComputerBuilder
{
    public override void BuildCPU()
    {
        Computer.CPU = "High-End Gaming CPU";
    }

    public override void BuildRAM()
    {
        Computer.RAM = "32GB DDR4 RAM";
    }

    public override void BuildStorage()
    {
        Computer.Storage = "1TB SSD";
    }
}

public class OfficeComputerBuilder : ComputerBuilder
{
    public override void BuildCPU()
    {
        Computer.CPU = "Business CPU";
    }

    public override void BuildRAM()
    {
        Computer.RAM = "8GB DDR4 RAM";
    }

    public override void BuildStorage()
    {
        Computer.Storage = "512GB SSD";
    }
}

// Director
public class ComputerAssembler
{
    public Computer Assemble(ComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildRAM();
        builder.BuildStorage();
        return builder.GetComputer();
    }
}
