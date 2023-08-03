using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    using System.Collections.Generic;

    public class CClass
    {
        public string ClassName { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public CClass(string className)
        {
            ClassName = className;
            Subjects = new List<Subject>();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
