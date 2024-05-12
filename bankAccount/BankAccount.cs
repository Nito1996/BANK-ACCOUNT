using System;
using System.Collections.Generic;
using System.Text;

namespace bankAccount
{ 
    class BankAccount
    {
        private double Balance {  get; set; }
        public string Owner {  get; set; }

        public BankAccount(string owner, double balance)
        {
            this.Balance = balance;
            this.Owner = owner;
        }

        public void Deposit()
        {
            Console.WriteLine("How much money do you want to save?");
            int deposit = Program.GetUserInput();
            if (deposit > 0)
            {
                Console.WriteLine($"Your new balance is {Balance + deposit}");
                Balance += deposit;
            }
            else
            {
                Console.WriteLine("Invalid request.");
            }
            Console.WriteLine("");
        }

        public void Withdraw()
        {
            Console.WriteLine("How much money do you want to withdraw?");
            int withdraw = Program.GetUserInput();
            if (withdraw > 0 && Balance >= withdraw)
            {
                Balance -= withdraw;
                Console.WriteLine($"Your new balance is {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid request.");
            }
            Console.WriteLine("");
        }

        public double ShowBalance()
        {
            Console.WriteLine($"Your current Balance is: {Balance}.");
            Console.WriteLine("");

            return Balance;
        }
    }
}
