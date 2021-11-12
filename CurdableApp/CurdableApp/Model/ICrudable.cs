using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurdableApp.Model
{
   public interface ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Created..");
        }
        public void Read()
        {
            Console.WriteLine("Read..");
        }
        public void Update()
        {
            Console.WriteLine("Update..");
        }
        public void Delete()
        {
            Console.WriteLine("Delete..");
        }

    }
}
