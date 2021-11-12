using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployePolymorphismApp.Model
{
    class Developer:Employe
    {
        public Developer(int EmpNo,string Name,double BasicSalary) : base(EmpNo, Name, BasicSalary)
        {

        }
        public override void Calculate()
        {
            base.TA = base.BasicSalary * 40 / 100;
            base.DA = base.BasicSalary * 30 / 100;

        }
    }
}
