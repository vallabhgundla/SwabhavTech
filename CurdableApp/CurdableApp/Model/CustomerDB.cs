using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurdableApp.Model
{
    abstract class CustomerDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Is Created");
        }
        public abstract void Delete();
        public void Read()
        {
            Console.WriteLine("Reading from file ");
        }
        public abstract void Update();

    }
}
