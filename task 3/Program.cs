using System;
using task_3;

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
                Person tempPerson = new Person(enteredInfromation[0], enteredInfromation[1], int.Parse(enteredInfromation[2]));
                people.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = from i in people
                     where i.Age >= 18 && i.Age <= 24
                     select i;

        foreach(var index in result)
        {
            Console.WriteLine(index);
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}