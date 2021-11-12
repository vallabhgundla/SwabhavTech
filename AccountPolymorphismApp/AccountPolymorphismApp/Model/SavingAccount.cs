using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp.Model
{
    class SavingAccount:Account
    {
        private double balance;

        public SavingAccount(int accno,string name,double bal) : base(accno, name, bal)
        {

        }
        public override void Withdraw(double amount)
        {
            int min_balance = 500;
            if ((balance - amount) > min_balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("limit reached");
            }
        }
    }
}
