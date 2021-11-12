using EmployePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager(101, "Vallabh",  15000);
            m1.Calculate();
            DisplayDetails(m1);

            Accountant a1 = new Accountant(102, "abc", 18000);
            a1.Calculate();
            DisplayDetails(a1);

            Developer d1 = new Developer(103, "xyz", 21000);
            d1.Calculate();
            DisplayDetails(d1);

            Console.ReadLine();
        }

        private static void DisplayDetails(Employe emp)
        {
            Console.WriteLine("-----SalarySlip-----");
            Console.WriteLine("Employe_No Is:" + emp.EmpNo);
            Console.WriteLine("Employe_Name Is:" + emp.Name); 
            Console.WriteLine("Employe_BasicSalary Is:" + emp.BasicSalary);

            Console.WriteLine("Employe_HRA:" + emp.HRA);
            Console.WriteLine("Employe_DA:" + emp.DA);
            Console.WriteLine("Employe_TA:" + emp.TA);
            Console.WriteLine("Employe_Perks:" + emp.perks);

            Console.ReadLine();
        }
        
    }
}
