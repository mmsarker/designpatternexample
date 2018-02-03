using Mizan.Platform.Patterns.FactoryMethod.Creator;
using Mizan.Platform.Patterns.FactoryMethod.Product;
using System;
using System.Reflection;

namespace Mizan.Practice.Patterns.FactoryMethod
{
    public class FactoryMethodClient
    {
        public void Test()
        {
            IAutoFactory factory = (IAutoFactory)Assembly.GetExecutingAssembly().CreateInstance("Mizan.Platform.Patterns.FactoryMethod.ConcreteCreator.ToyotaAutoFactory");
            IAuto auto = factory.CreateAutomobile();
            auto.TurnOff();
            auto.TurnOn();
        }
    }
}
