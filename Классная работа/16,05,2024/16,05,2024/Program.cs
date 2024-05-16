using System.Collections.Generic;
using System.Linq;
using static System.Console;
using school;
using System.Data.SqlTypes;
using System;

class Program {
    static void Main()
    {
            List<Student> students = new List<Student> {
            new Student("Mark", 3),
            new Student("Alex", 5),
            new Student("Max", 4),
            new Student("Anatoly", 3),
            new Student("Hurry", 5)
        };

            IEnumerable<Student> queryH = from s in students
                                      where (s.mark > 4) && (s.went = false)
                                      orderby s.mark descending
                                      select s;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"day {i + 1}");

            if (queryH.Count() > 0) { }
        }

    }
} 