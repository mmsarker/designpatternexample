using Mizan.Practice.Patterns.Decorator.Component;
using Mizan.Practice.Patterns.Decorator.ConcreteComponent;
using Mizan.Practice.Patterns.Decorator.ConcreteDecorator;
using System;

namespace Mizan.Practice.Patterns.Decorator
{
    public class DecoratorTest
    {
        public void Test()
        {
            Employee manager = new Manager("John");
            Employee officer = new Officer("David");
            Employee clerk = new Clerk("Michael");
            manager.ShowDetails();
            officer.ShowDetails();
            clerk.ShowDetails();

            Employee specialmanager = new SpecialEmployeeDecorator(manager);
            specialmanager.ShowDetails();

            Console.ReadKey();

        }        
    }
}
