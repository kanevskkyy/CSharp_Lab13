using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Speciality
    {
        public string SpecialityType { get; set; }
        public string SpecialityName { get; set; }
        public int FacNum { get; set; }

        public Speciality(string specialityType, string specialityName, int id)
        {
            SpecialityType = specialityType;
            SpecialityName = specialityName;
            FacNum = id;
        }
    }
}
