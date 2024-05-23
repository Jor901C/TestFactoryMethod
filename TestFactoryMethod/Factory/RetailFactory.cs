using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryMethod.Domain;

namespace TestFactoryMethod.Factory
{
    public class RetailFactory : ClientFactory
    {
        private readonly decimal _price;
        public readonly decimal Dicsount;
        private readonly string _name;

        public RetailFactory(string name ,decimal price)
        {
            _price = price;
            Dicsount = 5;
            _name = name;
        }
        public override IClient GetDiscountAmount()
        {
            Retail client = new(_name , _price)
            {
                Amount = _price - ((_price / 100) * Dicsount)
            };
            return client;

        }
    }
}
