using System;


namespace dz_20._04._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     N№1");
            // Создание объекта студента
            Student student = new Student("Иванов", "Иван", "Иванович", "Группа 1", 20);

            // Установка оценок
            student.УстановитьОценку(0, 5); // Оценка по программированию
            student.УстановитьОценку(0, 4);
            student.УстановитьОценку(1, 3); // Оценка по администрированию
            student.УстановитьОценку(2, 5); // Оценка по дизайну

            // Вывод данных о студенте
            student.РаспечататьДанные();
            Console.WriteLine("\n     N№2");

            Pyramid pyramid = new Pyramid();
            pyramid.ShowInfo();

            HangingGardens gardens = new HangingGardens();
            gardens.ShowInfo();

            StatueOfZeus statue = new StatueOfZeus();
            statue.ShowInfo();

            TempleOfArtemis temple = new TempleOfArtemis();
            temple.ShowInfo();

            Mausoleum mausoleum = new Mausoleum();
            mausoleum.ShowInfo();

            Colossus colossus = new Colossus();
            colossus.ShowInfo();

            Lighthouse lighthouse = new Lighthouse();
            lighthouse.ShowInfo();
        }
    }
}
