using Mizan.Platform.Patterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Platform.Patterns.FactoryMethod.Creator
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}
