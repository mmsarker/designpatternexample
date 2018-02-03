using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Decorator.Component
{
    public abstract class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }
        public string Name{ get; set; }
        public string DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public abstract void ShowDetails();
    }
}
