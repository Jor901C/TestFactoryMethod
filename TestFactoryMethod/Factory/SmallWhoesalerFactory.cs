using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryMethod.Domain;

namespace TestFactoryMethod.Factory
{
    public class SmallWhoesalerFactory : ClientFactory
    {
        private readonly decimal _price;
        public readonly decimal Dicsount;
        private readonly string _name;
        public SmallWhoesalerFactory(string name , decimal price)
        {
            _name = name;
            _price = price;
            Dicsount = 20;
        }
        public override IClient GetDiscountAmount()
        {
            SmallWholeaser client = new(_name, _price)
            {
                Amount = _price - ((_price / 100) * Dicsount)
            };
            return client;

        }
    }
}
