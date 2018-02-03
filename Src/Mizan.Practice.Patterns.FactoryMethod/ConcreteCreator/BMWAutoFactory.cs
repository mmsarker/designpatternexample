using Mizan.Platform.Patterns.FactoryMethod.Creator;
using System;
using System.Collections.Generic;
using System.Text;
using Mizan.Platform.Patterns.FactoryMethod.Product;
using Mizan.Platform.Patterns.FactoryMethod.ConcreteProduct;

namespace Mizan.Platform.Patterns.FactoryMethod.ConcreteCreator
{
    public class BMWAutoFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMWAuto();
        }
    }
}
