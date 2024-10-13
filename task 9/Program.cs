using System;
using task_9;

class Task
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            string[] enteredInfromation = Console.ReadLine().Split();
            if (enteredInfromation[0].ToLower() == "end") break;
            else
            {
                List<int> grades = new List<int>();
                for (int i = 1; i < enteredInfromation.Length; i++)
                {
                    grades.Add(int.Parse(enteredInfromation[i]));
                }

                Student tempPerson = new Student(enteredInfromation[0], grades);
                students.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = from p in students
                     where (p.Id[4] == '1' && p.Id[5] == '4') || p.Id.Contains("15")
                     select p;

        foreach (var index in result)
        {
            Console.WriteLine(index);
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}