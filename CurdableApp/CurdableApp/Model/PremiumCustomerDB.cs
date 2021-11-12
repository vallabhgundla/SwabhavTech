using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurdableApp.Model
{
    class PremiumCustomerDB:CustomerDB
    {
        public override void Update()
        {
            Console.WriteLine("Premium Customer Updated..");
        }
        public override void Delete()
        {
            Console.WriteLine("Premium Customer Delete..");
        }
    }
}
