using Mizan.Practice.Patterns.AdapterPattern;
using Mizan.Practice.Patterns.Bridge;
using Mizan.Practice.Patterns.ChainOfResponsibility;
using Mizan.Practice.Patterns.Command;
using Mizan.Practice.Patterns.Command.Invoker;
using Mizan.Practice.Patterns.Composite;
using Mizan.Practice.Patterns.Decorator;
using Mizan.Practice.Patterns.FactoryMethod;
using Mizan.Practice.Patterns.Observer;
using Mizan.Practice.Patterns.Prototype;
using Mizan.Practice.Patterns.StatePattern;
using System;

namespace Mizan.Practice.Patterns.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductDataClient productDataClient = new ProductDataClient();
            //productDataClient.showPoducts();
            //Console.ReadKey();

            //PurchaseClient purchaseClient = new PurchaseClient();
            //purchaseClient.Purchase();
            //Console.ReadKey();
            /*
            CalculatorUser calculatorUser = new CalculatorUser();
            calculatorUser.Compute(CommandType.AddCommand, 10);
            calculatorUser.Compute(CommandType.AddCommand, 100);
            calculatorUser.Compute(CommandType.SubstractCommand, 20);
            calculatorUser.Undo();
            calculatorUser.Undo();
            calculatorUser.Undo();
            calculatorUser.Redo();
            calculatorUser.Redo();
            calculatorUser.Redo();

            Console.ReadKey();
            */
            //new FactoryMethodClient().Test();
            //new DecoratorTest().Test();
            //new CompositeClient().Test();

            //new BridgeClient().Test();
            //new StatePatternTest().Test();
            //new PrototypeClient().Test();
            //new ObserverClient().Test();
            new Mediator.MediatorClient().Test();

            Console.ReadKey();
        }
    }
}
