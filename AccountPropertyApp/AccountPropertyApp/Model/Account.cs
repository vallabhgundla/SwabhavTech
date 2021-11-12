using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPropertyApp.model
{
    class Account
    {
        private double _defaultBalance = 500;
        private int _accountNo;
        private string _name;
        private double _balance;

        public Account(int account_no, string name, double balance)
        {
            this._accountNo=account_no;
            this._name=name;
            this._balance=balance;          
        }

        public Account(int v1, string v2)
        {
            this._accountNo = v1;
            this._name = v2;
        }

        public double Deposite(double amount)
        {
            _balance += amount;
            return _balance;
        }
        public void Withdraw(double amount)
        {
            if (amount < _balance)
            {
                _balance -= amount;
                Console.WriteLine("SuccessFull........");
            }
            else
            {
                Console.WriteLine("Failed...");
            }
        }
        public int account
        {
            get
            {
                return _accountNo;
            }
            
        }
        public string Name
        {
            get
            {
                return _name;
            }
            

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
