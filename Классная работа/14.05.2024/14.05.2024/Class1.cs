using System;
namespace prog
{
    class Car
    {
        public delegate void handler(Car c);
        public event handler? Collision;

        string name {  get; set; }
        int Life { get; set; }

        public Car(int life, string n)
        {
            Life = life;
            name = n;
        }
        public void update(int a)
        {
            if (a == 0) Collision(this);
        }
        public override string ToString() {  return name; }
    }
}
