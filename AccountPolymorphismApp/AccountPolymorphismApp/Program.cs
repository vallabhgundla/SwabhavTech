using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount acc1 = new SavingAccount(101, "Vallabh", 5000);
            PrintDetails(acc1);

            CurrentAccount acc2 = new CurrentAccount(102, "Raj", 7000);
            PrintDetails(acc2);

            acc1.Withdraw(2000);
            PrintDetails(acc1);

            acc2.Withdraw(5000);
            PrintDetails(acc2);

            Console.ReadLine();
        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Account_Number is:" + acc.GetAccount());
            Console.WriteLine("Name Is:" + acc.GetName());
            Console.WriteLine("Balance Is:" + acc.Balance);
            Console.WriteLine();
        }
    }
}
