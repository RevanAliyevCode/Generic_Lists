using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask
{
    public class Course
    {
        private List<Student> Students = [];

        public void AddStudent(Student student)
        {
            Student? finded = Students.FirstOrDefault(s => s.PIN == student.PIN);

            if (finded == null) Students.Add(student);
            else Console.WriteLine("You can not have same pin with existing student");
        }

        public void RemoveStudent(Student student) => Students.Remove(student);

        public void AllStudents()
        {
            foreach (Student student in Students) student.GetDetails();
        }

        public void OverEighteen()
        {
            foreach (Student student in Students)
            {
                if (student.Age >= 18) student.GetDetails();
            }
        }

        public Student? FindStudent(string pin)
        {
            Student? finded = Students.FirstOrDefault(s => s.PIN == pin);
            if (finded == null) Console.WriteLine("We do not have such a student");
            return finded;
        }

        public int TotalStudent() => Students.Count;
    }
}
