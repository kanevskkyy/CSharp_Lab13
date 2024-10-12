using System;
using task_5;

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
                Person tempPerson = new Person(enteredInfromation[0], enteredInfromation[1], enteredInfromation[2]);
                people.Add(tempPerson);
            }
            Line();
        }

        Line();

        var result = from p in people
                     where p.Email.Contains("@gmail.com")
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