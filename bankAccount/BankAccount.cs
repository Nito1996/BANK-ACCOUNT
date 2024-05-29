using System;
using System.Collections.Generic;
using System.Text;

namespace bankAccount
{ 
    class BankAccount
    {
        private decimal Balance {  get; set; }
        public string Owner { get; set; }

        public BankAccount(string owner, decimal balance)
        {
            this.Balance = balance;
            this.Owner = owner;
        }

        public bool Deposit()
        {
            int deposit = Program.GetUserInput();
            if (deposit > 0)
            {
                Balance += deposit;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw()
        {
            int withdraw = Program.GetUserInput();
            if (withdraw > 0 && Balance >= withdraw)
            {
                Balance -= withdraw;
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal ShowBalance()
        {
            return Balance;
        }
    }
}
