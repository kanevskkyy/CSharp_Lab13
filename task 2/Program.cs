using System;
using task_2;

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

        var result = from i in people
                     where i.FirstName.CompareTo(i.LastName) < 0
                     select i;

        Console.Write("Result = ");
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