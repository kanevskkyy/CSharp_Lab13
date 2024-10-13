using System;
using task_11;

class Task
{
    static void Main()
    {
        List<Speciality> specialities = new List<Speciality>();
        List<Student> students = new List<Student>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Students:") break;
            else
            {
                string[] enteredInfromation = input.Split();
                specialities.Add(new Speciality(enteredInfromation[0], enteredInfromation[1], int.Parse(enteredInfromation[2])));
            }
        }

        while (true)
        {
            string[] enteredInfromation = Console.ReadLine().Split();
            if (enteredInfromation[0].ToLower() == "end") break;
            else students.Add(new Student(int.Parse(enteredInfromation[0]), enteredInfromation[1], enteredInfromation[2]));
        }

        var result = from student in students
                     join specialty in specialities on student.FacNum equals specialty.FacNum
                     orderby student.Name
                     select new
                     {
                         student.Name,
                         student.Surname,
                         student.FacNum,
                         specialty.SpecialityType,
                         specialty.SpecialityName
                     };

        foreach(var student in result)
        {
            Console.WriteLine($"{student.Name} {student.Surname} {student.FacNum} {student.SpecialityType} {student.SpecialityName}");
        }

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}