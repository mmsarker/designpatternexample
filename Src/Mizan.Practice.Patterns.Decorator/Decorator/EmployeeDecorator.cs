using Mizan.Practice.Patterns.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Decorator.Decorator
{
    public class EmployeeDecorator : Employee
    {
        protected Employee _employee;
        public EmployeeDecorator(Employee employee) : base(employee.Name)
        {
            this._employee = employee;
        }
        public override void ShowDetails()
        {
            if (this._employee != null)
            {
                this._employee.ShowDetails();
            }
        }
    }
}
