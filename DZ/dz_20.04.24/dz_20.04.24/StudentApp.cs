using System;
namespace dz_20._04._24
{
    class Student
    {
        // Свойства студента
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Группа { get; set; }
        public int Возраст { get; set; }
        public int[][] Оценки { get; set; }

        // Конструктор класса
        public Student(string фамилия, string имя, string отчество, string группа, int возраст)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Группа = группа;
            Возраст = возраст;
            Оценки = new int[3][];
            Оценки[0] = new int[0]; // Оценки по программированию
            Оценки[1] = new int[0]; // Оценки по администрированию
            Оценки[2] = new int[0]; // Оценки по дизайну
        }

        // Метод для установки оценки
        public void УстановитьОценку(int предмет, int оценка)
        {
            if (предмет >= 0 && предмет < Оценки.Length)
            {
                Array.Resize(ref Оценки[предмет], Оценки[предмет].Length + 1);
                Оценки[предмет][Оценки[предмет].Length - 1] = оценка;
            }
        }

        // Метод для получения среднего балла по заданному предмету
        public double СреднийБалл(int предмет)
        {
            if (предмет >= 0 && предмет < Оценки.Length)
            {
                int сумма = 0;
                foreach (int оценка in Оценки[предмет])
                {
                    сумма += оценка;
                }
                return (double)сумма / Оценки[предмет].Length;
            }
            return 0;
        }

        // Метод для распечатки данных о студенте
        public void РаспечататьДанные()
        {
            Console.WriteLine("Фамилия: " + Фамилия);
            Console.WriteLine("Имя: " + Имя);
            Console.WriteLine("Отчество: " + Отчество);
            Console.WriteLine("Группа: " + Группа);
            Console.WriteLine("Возраст: " + Возраст);
            Console.WriteLine("Оценки по программированию: " + string.Join(", ", Оценки[0]));
            Console.WriteLine("Оценки по администрированию: " + string.Join(", ", Оценки[1]));
            Console.WriteLine("Оценки по дизайну: " + string.Join(", ", Оценки[2]));
        }
    }
}

