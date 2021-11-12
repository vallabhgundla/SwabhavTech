using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp.Model
{
    class Boy:Man
    {
        public void Play()
        {
            Console.WriteLine("Boy Is Playing...");
        }

        public void Jump()
        {
            Console.WriteLine("Boy Is Jumping...");
        }

        public void Walk()
        {
            Console.WriteLine("Boy Is Walking...");
        }

        public void Read()
        {
            Console.WriteLine("Boy Is Reading...");
        }
    }
}
