using AdvaitCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.CubeEvenNumber(2);

            Console.WriteLine("Cube Of A Number Is" + c.CubeEvenNumber(2));
            Console.WriteLine();
        }
    }
}
