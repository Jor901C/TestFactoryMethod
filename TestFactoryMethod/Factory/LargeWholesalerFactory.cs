using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryMethod.Domain;

namespace TestFactoryMethod.Factory
{
    public class LargeWholesalerFactory : ClientFactory
    {
        private readonly decimal _price;
        public readonly decimal Dicsount;
        private readonly string _name;
        public LargeWholesalerFactory(string name ,decimal price)
        {
            _name = name;
            Dicsount = 35;
            _price = price;   
        }
        public override IClient GetDiscountAmount()
        {
            LargeWholesaler client = new(_name, _price)
            {
               Amount = _price - ((_price / 100) * Dicsount)
            };
            return client;
        }
    }
}

