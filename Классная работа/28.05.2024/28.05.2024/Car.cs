using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._2024
{
    internal abstract class Car
    {
        public delegate bool Damaged(int value);
        public event Damaged? hit_from_pit;
        public int Life { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }

        public Car(string _name) : this(_name, 30, 1) { }
        public Car(string _name, int _life, int _speed)
        {
            Life = _life;
            Name = _name;
            Speed = _speed;
        }
    }
}
