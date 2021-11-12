using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private int rollno;
        private string name;
        private string location;

        public Student(int rollno,string name, string location)
        {
            this.rollno = rollno;
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

        internal int GetHashCode(Student s1)
        {
            throw new NotImplementedException();
        }
    }
}
