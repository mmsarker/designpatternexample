using Mizan.Platform.Patterns.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Platform.Patterns.FactoryMethod.ConcreteProduct
{
    public class ToyotaAuto : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn off Toyota");
        }

        public void TurnOn()
        {
            Console.WriteLine("Tur on Toyota");
        }
    }
}
