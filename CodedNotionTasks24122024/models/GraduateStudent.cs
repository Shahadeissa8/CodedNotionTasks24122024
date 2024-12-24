using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodedNotionTasks24122024.models
{                                           //bonus question
    internal class GraduateStudent : Student //the child class, inherited some of the variables in the "Student" parent class. ":" is used to show that 
    {
        public string Supervisor;
        public string SeniorProject;

        public string graduate()
        {           // as we will see we wont define Name, Major nor GPA again as this class inherited them from the parent
            return "graduate student is: "+ Name +
                "\ngraduate student major is: " + Major + 
                "\ngraduate student's gpa is: " +GPA + 
                "\nStudent supervisor is: " + Supervisor +
                "\nstudent senior project is: " + SeniorProject;
        }
    }
}

