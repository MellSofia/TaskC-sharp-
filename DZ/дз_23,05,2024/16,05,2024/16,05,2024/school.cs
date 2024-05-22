using school;
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
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public bool Went { get; set; }
        public bool Punished { get; set; }
        public int PunishedCount { get; set; }
        public int WentCount { get; set; }

        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
            Went = false;
            Punished = false;
            PunishedCount = 0;
            WentCount = 0;
        }
    }


}