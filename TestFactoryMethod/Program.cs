using TestFactoryMethod.Domain;
using TestFactoryMethod.Factory;

namespace TestFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<Welcome in our store>>>>>>>");
                Console.WriteLine("<<<<<<<What is your name? >>>>>>>");
                string? name = Console.ReadLine();
               if(string.IsNullOrEmpty(name))
               {
                Console.WriteLine("Invalid name, please try again.");
                return;
               }
                Console.WriteLine($"<<<<<<< Dear {name} how much did you buy goods from us?>>>>>>>");
                string amountInput = Console.ReadLine();
                decimal amount;
                 if (!decimal.TryParse(amountInput, out amount))
                 {
                   Console.WriteLine("Invalid value , please try again");
                   return;
                 }
            ClientFactory factory = GetFactory(name, amount);
                if (factory == null)
                {
                    Console.WriteLine("Wrong data , please repeat");
                    return;
                }
                IClient client = factory.GetDiscountAmount();
                Console.WriteLine($"Dear {name} your  purchase including the discount amounted to {client.Amount}.");
            Console.WriteLine($"Your discount is {client.Discount}%");
            Console.ReadLine();
            
        }
        private static ClientFactory GetFactory(string name , decimal price)
        {
            if (price > 0 && price < 100)
                return new RetailFactory(name , price);
            if (price >= 100 && price < 1000 )
                return new SmallWhoesalerFactory(name,price);
            if (price >= 1000)
                return new LargeWholesalerFactory(name,price);
            else
            {
                return null;
            }
        }
    }
}
