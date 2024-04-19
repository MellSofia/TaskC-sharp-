using System;
namespace dz_20._04._24
{
    // Класс, описывающий одно чудо света
    public class Wonder
    {
        // Свойство
        public string Name { get; set; }

        // Конструктор
        public Wonder(string name)
        {
            Name = name;
        }

        // Метод для вывода информации о чуде
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Чудо: {Name}");
        }
    }
}
