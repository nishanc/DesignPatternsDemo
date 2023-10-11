// using System;

// public class PaymentProcessor
// {
//     public IPaymentMethod CreatePaymentMethod(string paymentType)
//     {
//         if (paymentType == "CreditCard")
//         {
//             return new CreditCardPayment();
//         }
//         else if (paymentType == "PayPal")
//         {
//             return new PayPalPayment();
//         }
//         else if (paymentType == "Bitcoin")
//         {
//             return new BitcoinPayment();
//         }
//         else if (paymentType == "Kidney")
//         {
//             return new BitcoinPayment();
//         }
//         else if (paymentType == "Sanath")
//         {
//             return new BitcoinPayment();
//         }
//         else
//         {
//             throw new ArgumentException("Invalid payment type");
//         }
//     }
// }

// public interface IPaymentMethod
// {
//     void ProcessPayment();
// }

// public class CreditCardPayment : IPaymentMethod
// {
//     public void ProcessPayment()
//     {
//         Console.WriteLine("Processing Credit Card Payment...");
//     }
// }

// public class PayPalPayment : IPaymentMethod
// {
//     public void ProcessPayment()
//     {
//         Console.WriteLine("Processing PayPal Payment...");
//     }
// }

// public class BitcoinPayment : IPaymentMethod
// {
//     public void ProcessPayment()
//     {
//         Console.WriteLine("Processing Bitcoin Payment...");
//     }
// }
