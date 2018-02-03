using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Prototype.ConcreteImplementation
{
    public class PythonDeveloper : IDeveloper
    {
        public string Name { get; set; }
        public string Expertise { get; set; }

        public IDeveloper Clone()
        {
            return (IDeveloper)this.MemberwiseClone();
        }

        public string GetDetails()
        {
            string detail = $"Name: {this.Name}   Expertise: {this.Expertise}";
            return detail;
        }
    }
}
