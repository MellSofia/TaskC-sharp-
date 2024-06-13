using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._2024
{
    internal class Car_Toyota : Car
    {
        public int Y { get; set; }
        public int Action { get; set; }
        public Car_Toyota(string _name) : base(_name) { Y = 0; }

        public Car_Toyota(string _name, int _life, int _speed) : base(_name, _life, _speed)
        {
            Y = 0;
        }

        public bool hit_handler(int value)
        {
            Life -= value;
            return Life > 0 ? true : false;
        }

        public int update_Y()
        {
            // 208 - floor



            return Y;
        }
    }
}
