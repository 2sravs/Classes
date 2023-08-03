using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                
                Subject math = new Subject("Mathematics", 101);
                Subject physics = new Subject("Physics", 102);
                Subject chemistry = new Subject("Chemistry", 103);

               
                Teacher teacher1 = new Teacher("sravs", 35);
                Teacher teacher2 = new Teacher("Jane", 40);

                
                Student student1 = new Student("AALI", 18);
                Student student2 = new Student("Bob ", 17);

                
                CClass class1 = new CClass("Class A");

                
                class1.AddSubject(math);
                class1.AddSubject(physics);
                class1.AddSubject(chemistry);

                class1.AddTeacher(teacher1);
                class1.AddTeacher(teacher2);

                class1.AddStudent(student1);
                class1.AddStudent(student2);

                
                Console.WriteLine("Class: " + class1.ClassName);
                Console.WriteLine("Subjects: ");
                foreach (var subject in class1.Subjects)
                {
                    Console.WriteLine("- " + subject.Name + " (Code: " + subject.Code + ")");
                }

                Console.WriteLine("Teachers: ");
                foreach (var teacher in class1.Teachers)
                {
                    Console.WriteLine("- " + teacher.Name + " (Age: " + teacher.Age + ")");
                }

                Console.WriteLine("Students: ");
                foreach (var student in class1.Students)
                {
                    Console.WriteLine("- " + student.Name + " (Age: " + student.Age + ")");
                }
            Console.ReadKey();
        }

            
    }
 }


