using InterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            Boy b = new Boy();

            AtThePartyHall(m );
            AtThePartyHall(b);

            AtTheCinemaHall(m);
            AtTheCinemaHall(b);

        }

        private static void AtTheCinemaHall(IManner obj)
        {
            Console.WriteLine("At The Party...");
            obj.Wish();
            obj.Depart();

        }

        private static void AtThePartyHall(IEmotion obj)
        {
            Console.WriteLine("At The Cinema Hall....");
            obj.Cry();
            obj.Laugh();
        }
    }
}
