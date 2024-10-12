using System;
using task_4;

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
                Person tempPerson = new Person(enteredInfromation[0], enteredInfromation[1]);
                people.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = people
            .OrderBy(p => p.LastName) 
            .ThenByDescending(p => p.FirstName);


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