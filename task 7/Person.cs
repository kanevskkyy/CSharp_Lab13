using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Grades { get; set; }

        public Person(string firstName, string lastName, List<int> grades)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = grades;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
