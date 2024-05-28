using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._2024
{
    internal class CarHaevy
    {
        public delegate bool Damaged();
        public event Damaged? hit_from_pit;
        public int Life { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }
        public CarHaevy(string _name) : this(_name, 3, 10) { }
        public CarHaevy(string _name, int _life, int _speed)
        {
            Life = _life;
            Speed = _speed;
            Name = _name;
        }
    }
}
