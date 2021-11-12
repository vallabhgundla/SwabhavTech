using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployePolymorphismApp.Model
{
    class Accountant:Employe
    {
       public Accountant(int EmpNo,string Name,double BasicSalary) : base(EmpNo, Name, BasicSalary)
        {

        }
        public override void Calculate()
        {
            perks = base.BasicSalary * 30 / 100;
        }
    }
}
