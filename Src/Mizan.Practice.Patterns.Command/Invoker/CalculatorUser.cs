using Mizan.Practice.Patterns.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Command.Invoker
{
    public class CalculatorUser
    {
        List<ICommand> commandList = new List<ICommand>();
        int current = 0;
        Calculator calculator = new Calculator();
        public void Compute(CommandType commandType, int operand)
        {            
            ICommand command = GetCommand(calculator, commandType, operand);
            commandList.Add(command);
            command.Execute();
            current = commandList.Count;
        }

        private ICommand GetCommand(Calculator calculator, CommandType commandType, int operand)
        {
            ICommand command = null;

            if (commandType == CommandType.AddCommand)
            {
                command = new AddCommand(calculator, operand);
            }
            else if (commandType == CommandType.SubstractCommand)
            {
                command = new SubstractCommand(calculator, operand);
            }

            return command;
        }

        public void Undo()
        {
            current = current - 1;
            ICommand command = commandList[current];
            command.UnExecute();
        }

        public void Redo()
        {
            ICommand command = commandList[current];
            command.Execute();
            current = current + 1;
        }
    }
}
