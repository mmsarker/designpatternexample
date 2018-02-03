using Mizan.Practice.Patterns.Prototype.ConcreteImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Prototype
{
    public class PrototypeClient
    {
        public void Test()
        {
            DotNetDeveloper dotNetDeveloper1 = new DotNetDeveloper
            {
                Name = "DotNetDeveloper1",
                Expertise = ".Net"
            };

            var dotNetDeveloper2 = dotNetDeveloper1.Clone() as DotNetDeveloper;
            dotNetDeveloper2.Name = "DotNetDeveloper2";

            Console.WriteLine(dotNetDeveloper1.GetDetails());
            Console.WriteLine(dotNetDeveloper2.GetDetails());


            PythonDeveloper pythonDeveloper1 = new PythonDeveloper
            {
                Name = "PythonDeveloper1",
                Expertise = "Python"
            };

            var pythonDeveloper2 = pythonDeveloper1.Clone() as PythonDeveloper;
            pythonDeveloper2.Name = "DotNetDeveloper2";

            Console.WriteLine(pythonDeveloper1.GetDetails());
            Console.WriteLine(pythonDeveloper2.GetDetails());
        }
    }
}
