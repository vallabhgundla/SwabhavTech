using AccountPropertyApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Vallabh", 1500);
            PrintDetails(acc1);
            acc1.Withdraw(300);
            PrintDetails(acc1);

            Account acc2 = new Account(102, "Abc");
            PrintDetails(acc2);
            acc2.Deposite(3000);
            PrintDetails(acc2);

        }
        static void PrintDetails(Account acc1)
        {
            Console.WriteLine("Account_Number is:" + acc1.account);
            Console.WriteLine("Name Is:" + acc1.Name);
            Console.WriteLine("Balance Is:" + acc1.Balance);
            Console.WriteLine();

        }


    }
}
