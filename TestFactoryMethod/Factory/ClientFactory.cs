using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryMethod.Domain;

namespace TestFactoryMethod.Factory
{
    public abstract class ClientFactory
    {
        public abstract IClient  GetDiscountAmount();
    }
}
