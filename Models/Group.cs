using System.Collections;

namespace Models;

public class Group : IEnumerable
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public Student[]? Students { get; set; }


    public IEnumerator GetEnumerator()
    {
        if (Students is null)
            throw new ArgumentNullException("Students is null");

        return Students.GetEnumerator();
    }

}