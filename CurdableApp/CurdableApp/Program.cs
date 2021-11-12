using CurdableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurdableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBoperations(new PremiumCustomerDB());
            DoDBoperations(new ProductDB());
            DoDBoperations(new OrderDB());
            Console.ReadLine();
        }

        private static void DoDBoperations(OrderDB orderDB)
        {
            throw new NotImplementedException();
        }

        private static void DoDBoperations(PremiumCustomerDB premiumCustomerDB)
        {
            throw new NotImplementedException();
        }

        private static void DoDBoperations(ProductDB productDB)
        {
            throw new NotImplementedException();
        }

        private static void DoDBoperations(ICurdable obj)
        {
            Console.WriteLine("\n All Database Operations.....");
            obj.Create();
            obj.Update();
            obj.Read();
            obj.Delete();

        }


    }
}
