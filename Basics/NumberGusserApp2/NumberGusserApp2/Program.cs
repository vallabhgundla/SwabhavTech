using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGusserApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1, 100);
            bool win = true;
           
            while(true) 
            {
                Console.Write("Game Developed By @Vallabh,Copyright @ 2021");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Guess number between 1 to 100 :");
                    string s = Console.ReadLine();
                    int i = int.Parse(s);
                    if (i > winNum)
                    {
                        Console.WriteLine(" Sorry To High..! Guess Lower....");
                        continue;
                    }
                    else if (i < winNum)
                    {
                        Console.WriteLine(" Sorry To Low...!  Guess High....");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Number Is : " + winNum);
                        Console.WriteLine("Winner winner chicken dinner...!");

                        Console.WriteLine("Do You Wanna Play Again...(y/n)");
                        string playAgain = Console.ReadLine();

                        Console.WriteLine("Thank You For Using The Application. Contact me vallabh.gundla@aurionpro.com !");

                        if (playAgain != "y")
                        {
                            win = false;
                        }
                        break;
                    }
                }
                   if (!win) break;
            }
           

        }
        
    }
}
