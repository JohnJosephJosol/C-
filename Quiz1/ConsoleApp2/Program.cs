using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public Person(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();


        while (true)
        {
            Console.Write("Enter person's name (type done if finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "done")
                break;

            Console.Write("Enter person's weight: ");
            int weight = int.Parse(Console.ReadLine());

            Person person = new Person(name, weight);
            people.Add(person);
        }


        Console.WriteLine("\nAll names entered:");
        foreach (Person person in people)
        {
            Console.WriteLine(person.Name);
        }


        int totalWeight = 0;
        foreach (Person person in people)
        {
            totalWeight += person.Weight;
        }
        Console.WriteLine("\nTotal weight of all people: " + totalWeight);
    }
}