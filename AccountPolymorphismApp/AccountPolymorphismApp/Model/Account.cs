using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
       
        private int _accountNo;
        private string _name;
        protected double _balance;
        
        public Account(int account_no, string name, double balance)
        {
            this._accountNo = account_no;
            this._name = name;
            this._balance = balance;
        }

        

        public double Deposite(double amount)
        {
            _balance += amount;
            return _balance;
        }
        public abstract void Withdraw(double amount);
        public int GetAccount()
        {
            return _accountNo;
        }
        public string GetName()
        {
            return _name;

        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
