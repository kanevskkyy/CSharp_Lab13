using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    internal class Person
    {
        public string Name { get; set; }
        public int GroupId { get; set; }

        public Person(string name, int groupId)
        {
            Name = name;
            GroupId = groupId;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}