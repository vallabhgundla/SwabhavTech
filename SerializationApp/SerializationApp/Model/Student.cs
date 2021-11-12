using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationApp.Model
{
    [Serializable]
    class Student
    {
        private string _name;
        private int _rollno;

        public Student(string name,int rollno)
        {
            this._name = name;
            this._rollno = rollno;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Rollno
        {
            get
            {
                return _rollno;
            }
        }
        
    }
}
