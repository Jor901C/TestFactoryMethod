using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethod.Domain
{
    public class LargeWholesaler : IClient
    {
        private readonly decimal _discount;
        public string Name { get;}
        public LargeWholesaler(string name , decimal purchaseAmotunt)
        {
            Name = name;
            _discount = 35;
        }

        
        public decimal Discount => _discount;
        public decimal Amount { get; set; }

    }
}
