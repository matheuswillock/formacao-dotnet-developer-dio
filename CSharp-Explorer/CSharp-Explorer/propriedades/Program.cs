using CSharp_Explorer.propriedades.Models;

Person person1 = new Person("Matheus", "Willock", 26);
person1.Apresentar();

Person person2 = new Person("Luffy", "Monkey", 17);
person2.Apresentar();

Person person3 = new Person("Zoro", "Roronoa", 21);
person3.Apresentar();

Person person4 = new Person("Robin", "Nico", 25);
person4.Apresentar();

Course course = new Course("Course 1");

Console.WriteLine($"\n{course.Name} is created!");

Console.WriteLine("---------------------------\n\nAdding Students in the course\n\n---------------------------");

course.AddStudent(person1);
course.AddStudent(person2);
course.AddStudent(person3);
course.AddStudent(person4);

Console.WriteLine("---------------------------\n\nview all Students in the course\n\n---------------------------");

course.AllStudents();

Console.WriteLine($"Students: {course.CountStudentsFull()}");

Console.WriteLine("---------------------------\n\n Removing student in the course\n\n---------------------------");

course.RemoveStudent(person2);

Console.WriteLine("---------------------------\n\nview all Students in the course\n\n---------------------------");

course.AllStudents();
Console.WriteLine($"Students: {course.CountStudentsFull()}");
