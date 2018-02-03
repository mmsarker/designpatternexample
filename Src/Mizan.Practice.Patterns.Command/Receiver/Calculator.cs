using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Command.Receiver
{
    public class Calculator
    {
        int result = 0;
        public void Add(int value)
        {
            result += value;
            Console.WriteLine("Result: " + result);
        }
        public void Substract(int value)
        {
            result = result - value;
            Console.WriteLine("Result: " + result);
        }
        public void Multiply(int value)
        {
            result = result * value;
            Console.WriteLine("Result: " + result);
        }
        public void Devide(int value)
        {
            result = result / value;
            Console.WriteLine("Result: " + result);
        }

        public void Clear()
        {
            result = 0;
            Console.WriteLine("Result: " + result);
        }
    }
}
