// See https://aka.ms/new-console-template for more information

using CourseTask;

bool exit = false;
Course course = new();
do
{
    Console.WriteLine("1. Add a new student\n2. Remove a student\n3. Display all students\n4. Search for a student\n5. Count total students\n6. Exit");
    int choise = int.Parse(Console.ReadLine());
    int count = course.TotalStudent();

    switch (choise)
    {
        case 1:
            Console.Write("Write name: ");
            string? name = Console.ReadLine();

            Console.Write("Write surname: ");
            string? surname = Console.ReadLine();

            Console.Write("Write age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Write pin: ");
            string? pin = Console.ReadLine();

            Student student = new(name, surname, age, pin);
            course.AddStudent(student);

            if (count < course.TotalStudent())
                Console.WriteLine("Student added successfully");

            break;
        case 2:
            Console.Write("Write student pin: ");
            string? pin2 = Console.ReadLine();

            Student? student1 = course.FindStudent(pin2);
            course.RemoveStudent(student1);

            if (count > course.TotalStudent()) Console.WriteLine("Deleted succesffully");
            break;
        case 3:
            course.AllStudents();
            break;
        case 4:
            Console.Write("Write pin: ");
            string? pin3 = Console.ReadLine();

            course.FindStudent(pin3)?.GetDetails();
            break;
        case 5:
            Console.WriteLine(course.TotalStudent());
            break;
        case 6:
            exit = true;
            break;
        default:
            Console.WriteLine("Please choise valid number");
            break;
    }

} while (!exit);

