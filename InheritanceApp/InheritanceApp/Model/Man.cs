using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp.Model
{
    class Man
    {
        public void Walk()
        {
            Console.WriteLine("Man Is Walking...");
        }

        public virtual void Play()
        {
            Console.WriteLine("Man Is Playing...");
        }

        public void Read()
        {
            Console.WriteLine("Man Is Reading...");
        }

        
    }
}
