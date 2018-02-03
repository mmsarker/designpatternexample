using Mizan.Platform.Patterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Platform.Patterns.FactoryMethod.ConcreteProduct
{
    public class BMWAuto : IAuto
    {        
        public void TurnOff()
        {
            Console.WriteLine("Turn off BMW");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on BMW");
        }
    }
}
