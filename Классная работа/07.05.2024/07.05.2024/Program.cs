using System;
using System.Collections;
using System.Collections.Specialized;

class Program
{
    static SortedList notebook = new SortedList();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Удалить запись");
            Console.WriteLine("3. Найти запись");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNote();
                    break;
                case "2":
                    RemoveNote();
                    break;
                case "3":
                    FindNote();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void AddNote()
    {
        Console.Write("Введите название записи: ");
        string title = Console.ReadLine();

        ListDictionary note = new ListDictionary();
        note.Add("Название", title);
        note.Add("Дата", DateTime.Now);
        note.Add("Важность", "Высокая");
        note.Add("Тип", "Обычная");
        note.Add("Текст", "Текст записи");

        notebook.Add(title, note);
    }

    static void RemoveNote()
    {
        Console.Write("Введите название записи для удаления: ");
        string title = Console.ReadLine();

        if (notebook.ContainsKey(title))
        {
            notebook.Remove(title);
            Console.WriteLine("Запись удалена.");
        }
        else
        {
            Console.WriteLine("Запись не найдена.");
        }
    }

    static void FindNote()
    {
        Console.Write("Введите название записи для поиска: ");
        string title = Console.ReadLine();

        if (notebook.ContainsKey(title))
        {
            ListDictionary note = (ListDictionary)notebook[title];
            foreach (DictionaryEntry entry in note)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        else
        {
            Console.WriteLine("Запись не найдена.");
        }
    }
}
