using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
