using prog;
using System;

class Program
{
    static void Main()
    {
        var car = new Car(3, "Car1"); // Создаем машину с 3 жизнями
        car.Collision += Car_Collision;
        car.Destroyed += Car_Destroyed;

        var rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            car.update(rnd.Next(1, 6));
            Console.Write("-");
            if (car.Life < 1) break; // Если у машины закончилась жизнь, завершаем цикл
        }
    }

    private static void Car_Destroyed()
    {
        Console.WriteLine("\nМашина уничтожена.");
    }

    private static void Car_Collision(Car c)
    {
        Console.WriteLine($"\nМашина {c} получила урон.");
    }
}