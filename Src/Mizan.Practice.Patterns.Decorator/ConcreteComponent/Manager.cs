using Mizan.Practice.Patterns.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Decorator.ConcreteComponent
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
            this.Salary = 50000.0m;
        }
        public override void ShowDetails()
        {
            Console.WriteLine(String.Format("This is manager {0} and his salary is {1}", this.Name, this.Salary));
        }
    }
}
