using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._2024
{
    internal class Car_Toyota : Car
    {
        public Car_Toyota(string _name) : base(_name){ }
        public Car_Toyota(string _name, int _life, int _speed) : base(_name,_life,_speed) { }
        public bool hit_handler(int value)
        {
            Life -= value;
            return Life>0?true: false;
        }
    }
}
