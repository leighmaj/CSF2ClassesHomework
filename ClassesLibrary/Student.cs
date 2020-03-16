using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public float GPA { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            GPA = gpa;
        }

        public override string ToString()
        {
            return string.Format("\n==== STUDENT ====\n\nStudent Name: {0} {1}\nID: {2}\nGPA: {3}\n", FirstName, LastName, Id, GPA);
        }


    }
}
