using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudenApp.model
{
    class Student
    {
        private int id;
        private string name, grade;
        private double percentage,cgpa;
        

        public void SetId(int StudId)
        {
            id = StudId;
        }
        public int GetId()
        {
            return id;
        }
        public void SetName(string Studname)
        {
            name = Studname;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCgpa(double StudCgpa)
        {
            cgpa = StudCgpa;
        }
        public double GetCgpa()
        {
            return cgpa;
        }
        public double calculatePercentage()
        {
            percentage = (float) (9.5 * (cgpa));
            SetGrade(percentage);
            return percentage;
        }
        private void SetGrade(double percentage)
        {
            if (percentage >= 75)
            {
                grade = "A";

            }
            else if (percentage >= 60)
            {
                grade = "B";
            }
            else if (percentage >= 50)
            {
                grade = "C";
            }
            else if (percentage >= 40)
            {
                grade = "D";
            }
            else
            {
                Console.WriteLine("Fail.....");
            }
        }
        public string GetGrade()
        {
            return grade;
        }
    }
}
