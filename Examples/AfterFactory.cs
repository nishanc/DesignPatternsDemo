using System;

public interface IPaymentMethod
{
    void ProcessPayment();
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card Payment...");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal Payment...");
    }
}

public class BitcoinPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Bitcoin Payment...");
    }
}

public interface IPaymentMethodFactory
{
    IPaymentMethod CreatePaymentMethod();
}

public class CreditCardPaymentFactory : IPaymentMethodFactory
{
    public IPaymentMethod CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }
}

public class PayPalPaymentFactory : IPaymentMethodFactory
{
    public IPaymentMethod CreatePaymentMethod()
    {
        return new PayPalPayment();
    }
}

public class BitcoinPaymentFactory : IPaymentMethodFactory
{
    public IPaymentMethod CreatePaymentMethod()
    {
        return new BitcoinPayment();
    }
}

public class PaymentProcessor
{
    private IPaymentMethodFactory paymentMethodFactory;

    public PaymentProcessor(IPaymentMethodFactory factory)
    {
        paymentMethodFactory = factory;
    }

    public void ProcessPayment()
    {
        IPaymentMethod paymentMethod = paymentMethodFactory.CreatePaymentMethod();
        paymentMethod.ProcessPayment();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create payment processors with the desired factory
        IPaymentMethodFactory creditCardFactory = new CreditCardPaymentFactory();
        PaymentProcessor creditCardProcessor = new PaymentProcessor(creditCardFactory);

        IPaymentMethodFactory payPalFactory = new PayPalPaymentFactory();
        PaymentProcessor payPalProcessor = new PaymentProcessor(payPalFactory);

        IPaymentMethodFactory bitcoinFactory = new BitcoinPaymentFactory();
        PaymentProcessor bitcoinProcessor = new PaymentProcessor(bitcoinFactory);

        // Process payments
        creditCardProcessor.ProcessPayment();
        payPalProcessor.ProcessPayment();
        bitcoinProcessor.ProcessPayment();
    }
}