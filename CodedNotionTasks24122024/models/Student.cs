using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedNotionTasks24122024.models
{
    internal class Student // Parent class: its the class where we define some variables,
                           // and then gives it to its children, we will see how is that in the child class "GraduateStudent"
    {
        public string Name;
        public string Major;
        public double GPA;

        public string studentSummary() 
        {
            return "student name is:  " + Name + "\nstudent major is: " + Major + "\nstudent gpa is: " + GPA; //requesting to print them
        }
    }
}

