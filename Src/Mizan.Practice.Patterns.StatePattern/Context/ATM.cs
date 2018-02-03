using Mizan.Practice.Patterns.StatePattern.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.Context
{
    public class ATM
    {
        public ATMState CurrentState { get; set; }
        public ATM()
        {
            CurrentState = new NoCardState();
        }

        public void StartAtm()
        {
            while (true)
            {
                CurrentState.Handle(this);
            }
        }
    }
}
