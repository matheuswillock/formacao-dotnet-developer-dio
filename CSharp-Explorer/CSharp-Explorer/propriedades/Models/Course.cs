namespace CSharp_Explorer.propriedades.Models;

public class Course
{
    public Course(string name)
    {
        Name = name;
        Students = new List<Person>();
    }
    
    public string Name { get; set; }
    public List<Person> Students { get; set; }

    public void AddStudent(Person student)
    {
        Students.Add(student);
        Console.WriteLine($"The student {student.Name} add in the {Name}");
    }

    public int CountStudentsFull() => Students.Count;

    public void AllStudents()
    {
        foreach (var student in Students)
        {
            Console.WriteLine($"Student {student.FullName} ");
        }
    }

    public void RemoveStudent(Person student)
    {
        Students.Remove(student);
        Console.WriteLine($"Aluno {student.Name} removido com sucesso!");
    }
    
    



}