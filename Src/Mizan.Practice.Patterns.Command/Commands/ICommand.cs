using System;

namespace Mizan.Practice.Patterns.Command
{
    public interface ICommand
    {        
        void Execute();
        void UnExecute();
    }
}
