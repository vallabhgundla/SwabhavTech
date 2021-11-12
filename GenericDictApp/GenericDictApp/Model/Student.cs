using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictApp.Model
{
    class Student
    {
        private int rollno;
        private int s;
        private string name;
        private string location;

        public Student(int rollno, int  s, string name, string location)
        {
            this.rollno = rollno;
            this.s = s;
            this.name = name;
            this.location = location;
        }
        public int Rollno
        {
            get
            {
                return rollno;
            }
        }
        public int S
        {
            get
            {
                return s;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
        }

        public int GetHashCode(Student s1)
        {
            return s;
        }
    }
}
