using System;
using prog;

class HelloWord 
{ 
    static void Main()
    {
        Console.WriteLine();

        Car c = new Car(3, "light");
        c.Collision += (Car cur_car) => { Console.WriteLine(cur_car+"hitted"); };

        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            c.update(rnd.Next(1, 5));
        }
    }
}

