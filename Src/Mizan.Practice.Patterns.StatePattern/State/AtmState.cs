using Mizan.Practice.Patterns.StatePattern.Context;
using System;

namespace Mizan.Practice.Patterns.StatePattern
{
    public abstract class ATMState
    {
//        public ATMState CurrentState { get; set; }
        public abstract void Handle(ATM atm);
    }
}
