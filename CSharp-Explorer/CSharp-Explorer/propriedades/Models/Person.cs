namespace CSharp_Explorer.propriedades.Models;

public class Person
{
    public Person(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }
    
    private string _name;
    private int _age;
    private string _lastName;

    public string Name
    {
        get => _name.ToUpper();

        set
        {
            if (value is "" or " ")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _name = value;
        }
    }

    public string LastName 
    {  
        get => _lastName.ToUpper();

        set
        {
            if (value is "" or " ")
            {
                throw new ArgumentException("O sobrenome não pode ser vazio");
            }
            _lastName = value;
        } 
    }
    
    public string FullName => $"{Name} {LastName}";
    
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa");
            }
            _age = value;
        }
    }
    
    public void Apresentar()
    {
        Console.WriteLine($"Hello! My name is {FullName} and I am {Age} years old.");
    }
}