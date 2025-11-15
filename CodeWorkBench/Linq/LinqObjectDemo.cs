using System;
using System.Linq;
using System.Collections.Generic;
using CodeWorkBench.Models;

namespace CodeWorkBench.Linq;

public class LinqObjectDemo
{
    public static void Demo()
    {
        Console.WriteLine("\nLINQ Object Demo\n");

        List<Person> people = new List<Person>()
        {
            new Person { Name = "John", Age = 23, Salary = 22500 },
            new Person { Name = "Sarah", Age = 37, Salary = 62000 },
            new Person { Name = "James", Age = 56, Salary = 45500 },
            new Person { Name = "Chloe", Age = 24, Salary = 27400 },
            new Person { Name = "Earl", Age = 47, Salary = 55000 },
        };
        
        // 1. Filter people older than 25
        var aboveTwentyFive = people.Where(person => person.Age > 25);
        
        Console.WriteLine("People older than 25:");
        foreach (var person in aboveTwentyFive)
            Console.WriteLine(person.Name);
    }
}