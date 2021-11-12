using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializationAndDeserializationApp.Model
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public Student()
        {
            
        }
        public int id
        {
            get
            {
                return id;
            }
        }
        public string name
        {
            get
            {
                return name;
            }
        }

       
    }
}
