using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethod.Domain
{
    public interface IClient
    {
        public string Name { get; }
        public decimal Discount { get; }
        public decimal Amount { get; set; }



    }
}
