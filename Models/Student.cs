namespace Models;


public class Student : IComparable<Student>, IDisposable
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateOnly BirthDate { get; set; }

    public Student() { }

    public Student(string? name, string? surname, DateOnly birthDate)
    {
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
    }


    public override string ToString()
        => $@"Id: {Id}
Name: {Name}
Surname: {Surname}
BirthDate: {BirthDate}
";


    public int CompareTo(Student? other)
        => BirthDate.CompareTo(other?.BirthDate);



    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
}