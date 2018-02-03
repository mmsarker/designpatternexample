using Mizan.Platform.Patterns.FactoryMethod.ConcreteProduct;
using Mizan.Platform.Patterns.FactoryMethod.Creator;
using Mizan.Platform.Patterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Platform.Patterns.FactoryMethod.ConcreteCreator
{
    public class ToyotaAutoFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new ToyotaAuto();
        }
    }
}
