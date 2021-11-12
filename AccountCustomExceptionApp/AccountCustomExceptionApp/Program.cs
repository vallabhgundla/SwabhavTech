using AccountCustomExceptionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "Vallabh", 5000);

            try
            {
                acc.Withdraw(4501);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\n Will Execute No Matter Exception Or Not.....");
                PrintDetails(acc);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("End Of Main..");
            Console.ReadLine();

        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Account_Number is:" + acc.GetAccount());
            Console.WriteLine("Name Is:" + acc.GetName());
            Console.WriteLine("Balance Is:" + acc.GetBalance());
            Console.WriteLine();
        }
        
    }
}
