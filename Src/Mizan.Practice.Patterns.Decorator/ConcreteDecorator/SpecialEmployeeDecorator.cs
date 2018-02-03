using Mizan.Practice.Patterns.Decorator.Component;
using Mizan.Practice.Patterns.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Decorator.ConcreteDecorator
{
    public class SpecialEmployeeDecorator : EmployeeDecorator
    {
        public SpecialEmployeeDecorator(Employee employee) : base(employee)
        {
        }

        public override void ShowDetails()
        {
            base.ShowDetails();

            Console.WriteLine("{0} is a special employee. He will get 10% more salary", this._employee.Name);
            this._employee.Salary = this._employee.Salary + (this._employee.Salary * .1m);

            Console.WriteLine("His new salary is " + this._employee.Salary);
        }
    }
}

