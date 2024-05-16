using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Student
    {
        public int mark;
        public string Name { get; set; }
        public bool went {  get; set; }
        public bool punished {  get; set; }

        public Student(string name, int mark1)
        {
            Name = name;
            went = false;
            punished = false;
            mark=mark1;
        }
    }

}
