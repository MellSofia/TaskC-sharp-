using System;

namespace prog
{
    class Car
    {
        public delegate void handler(Car c);
        public event handler Collision;
        public event Action Destroyed;

        string name { get; set; }
        public int Life { get; set; }

        public Car(int life, string n)
        {
            Life = life;
            name = n;
        }
        public void update(int a)
        {
            if (a == 3) // Урон наносится, если переданное значение равно 3
            {
                Life--;
                Collision?.Invoke(this);
            }
            if (Life < 1) // Если у машины закончилась жизнь
            {
                Destroyed?.Invoke();
            }
        }
        public override string ToString() { return name; }
    }
}
