using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PIN { get; set; }

        public Student(string name, string surname, int age, string pin)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PIN = pin;
        }

        public void GetDetails() =>
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Pin: {PIN}");
    }
}
