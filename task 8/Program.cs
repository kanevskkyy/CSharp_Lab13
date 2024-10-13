using System;
using task_8;

class Task
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        while (true)
        {
            string[] enteredInfromation = Console.ReadLine().Split();
            if (enteredInfromation[0].ToLower() == "end") break;
            else
            {
                List<int> grades = new List<int>();
                for (int i = 2; i < enteredInfromation.Length; i++)
                {
                    grades.Add(int.Parse(enteredInfromation[i]));
                }

                Person tempPerson = new Person(enteredInfromation[0], enteredInfromation[1], grades);
                people.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = from p in people
                     where p.Grades.Count(g => g <= 3) >= 2
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