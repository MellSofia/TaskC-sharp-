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
                new Student("Mark"),
                new Student("Alex"),
                new Student("Max"),
                new Student("Anatoly"),
                new Student("Hurry")
            };

        Random rnd = new Random();

        // Инициализация оценок
        foreach (var student in students)
        {
            for (int i = 0; i < 100; i++)
            {
                student.Marks.Add(rnd.Next(2, 6));
            }
        }

        Student lastWent = null;

        for (int day = 0; day < 100; day++)
        {
            Console.WriteLine($"Day {day + 1}");

            // Запросы
            var excellentStudents = students.Where(s => s.Marks.Last() == 5 && !s.Went && !s.Punished).ToList();
            var badStudents = students.Where(s => s.Marks.Last() == 2).ToList();
            var wentAndNotPunished = students.Where(s => s.Went && !s.Punished).ToList();
            var punishedStudents = students.Where(s => s.Punished).ToList();

            // Выбор студента для выполнения задания
            Student toGo;
            if (excellentStudents.Any())
            {
                toGo = excellentStudents[rnd.Next(excellentStudents.Count)];
            }
            else
            {
                toGo = students[rnd.Next(students.Count)];
            }

            toGo.Went = true;
            toGo.WentCount++;

            // Наказание студента, если он не выполнил задание
            if (lastWent != null && lastWent.Marks.Last() != 5)
            {
                lastWent.Punished = true;
                lastWent.PunishedCount++;
            }

            // Обновление статуса студентов
            foreach (var student in students)
            {
                if (student.Went)
                {
                    student.Went = false;
                }
                if (student.Punished)
                {
                    student.Punished = false;
                }
            }

            lastWent = toGo;
        }

        // Вывод статистики
        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student.Name}, Went: {student.WentCount}, Punished: {student.PunishedCount}, Average Mark: {student.Marks.Average()}");
        }
    }
} 