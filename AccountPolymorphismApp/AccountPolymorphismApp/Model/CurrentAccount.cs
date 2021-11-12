using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount:Account
    {
       
        public CurrentAccount(int account_no, string name, double balance) : base(account_no, name, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (DoOverDraftCheck())
            {
                _balance = Balance - amount;

            }
        }
        private bool DoOverDraftCheck()
        {
            return true;
        }
    }
}
