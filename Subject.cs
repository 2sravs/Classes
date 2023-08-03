using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Subject
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Subject(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
}
