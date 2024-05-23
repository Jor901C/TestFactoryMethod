using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethod.Domain
{
    public class Retail : IClient
    {
        private readonly decimal _discount;
        public string Name { get; }

        public Retail( string name ,decimal purchaseAmotunt)
        {
            Name = name;
            _discount = 5;
        }

        public decimal Discount => _discount;
        public decimal Amount { get; set; }


        
    }
}
