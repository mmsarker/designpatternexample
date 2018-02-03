using Mizan.Practice.Patterns.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Command
{
    public class AddCommand : ICommand
    {
        public int _value { get; set; }
        private Calculator _calculator;
        public AddCommand(Calculator calculator, int value)
        {
            this._calculator = calculator;
            this._value = value;
        }
        public void Execute()
        {
            this._calculator.Add(this._value);
        }

        public void UnExecute()
        {
            this._calculator.Substract(this._value);
        }
    }
}
