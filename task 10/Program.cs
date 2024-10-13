using System;
using task_10;

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
                Person tempPerson = new Person(enteredInfromation[0], int.Parse(enteredInfromation[1]));
                people.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = from p in people
                     group p by p.GroupId into g
                     select new
                     {
                         GroupId = g.Key,
                         Names = g.Select(x => x.Name).ToList()
                     };

        foreach (var group in result)
        {
            Console.WriteLine($"{group.GroupId} - {string.Join(", ", group.Names)}");
        }

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}