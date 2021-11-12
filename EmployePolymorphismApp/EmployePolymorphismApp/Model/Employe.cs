using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployePolymorphismApp.Model
{
    abstract class Employe
    {
        int _EmpNo;
        string _Name;
        double _BasicSalary;
        public double HRA;
        public double TA;
        public double DA;
        public double perks;

        public Employe(int EmpNo,string Name,double BasicSalary)
        {
            _EmpNo = EmpNo;
            _Name = Name;
            _BasicSalary = BasicSalary;

        }
        public abstract void Calculate();
        public int EmpNo
        {
            get
            {
                return _EmpNo;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        public double BasicSalary
        {
            get
            {
                return _BasicSalary;
            }
        }
    }
}
