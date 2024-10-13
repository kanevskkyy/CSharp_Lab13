using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class Student
    {
        public string Id { get; set; }
        public List<int> Grades { get; set; }

        public Student(string id, List<int> grades)
        {
            Id = id;
            Grades = grades;
        }

        public override string ToString()
        {
            string result = "";
            foreach(int number in Grades)
            {
                result += number + " ";
            }
            return result;
        }
    }
}
