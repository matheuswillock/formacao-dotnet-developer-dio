using CSharp_Explorer.propriedades.Models;

namespace CSharp_Explorer.propriedades;

public class ExecuteSchool
{
    public ExecuteSchool()
    {
        
    }
    public void Execute()
    {
        var person1 = new Person("Matheus", "Willock", 26);
        person1.Apresentar();

        var person2 = new Person("Luffy", "Monkey", 17);
        person2.Apresentar();

        var person3 = new Person("Zoro", "Roronoa", 21);
        person3.Apresentar();

        var person4 = new Person("Robin", "Nico", 25);
        person4.Apresentar();

        var course = new Course("Course 1");

        Console.WriteLine($"\n{course.Name} is created!");

        Console.WriteLine("---------------------------\n\nAdding Students in the course\n\n---------------------------");

        course.AddStudent(person1);
        course.AddStudent(person2);
        course.AddStudent(person3);
        course.AddStudent(person4);

        Console.WriteLine("---------------------------\n\nview all Students in the course\n\n---------------------------");

        course.ViewAllStudents();

        Console.WriteLine($"Students: {course.CountStudentsFull()}");

        Console.WriteLine("---------------------------\n\n Removing student in the course\n\n---------------------------");

        course.RemoveStudent(person2);

        Console.WriteLine("---------------------------\n\nview all Students in the course\n\n---------------------------");

        course.ViewAllStudents();
        Console.WriteLine($"Students: {course.CountStudentsFull()}");

    }
    
}