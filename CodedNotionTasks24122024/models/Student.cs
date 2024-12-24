using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedNotionTasks24122024.models
{
    internal class Student
    {
        public string Name;
        public string Major;
        public double GPA;

        public string studentSummary(string name, string major, double GPA)
        {

            return "student name is:  " + name + "\nstudent major is: " + major + "\nstudent gpa is: " + GPA;
        }
    }
}

