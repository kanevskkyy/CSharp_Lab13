using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Student
    {
        public int FacNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int facNum, string name, string surname)
        {
            FacNum = facNum;
            Name = name;
            Surname = surname;
        }

    }
}
