using Models;
using static System.Console;

namespace Lesson10_1_Standard_Interfaces;


// Standard Interfaces

// IComparable
// IEnumerable
// IEnumerator
// IEquatable
// ICloneable
// IConvertible

// IDisposable

// IDictionary
// IList
// ICollection


class Program
{
    static void Main()
    {
        //int[] numbers = { 11, 2, 43, 543, 125, 6 };

        //Array.Sort(numbers);

        //foreach (var number in numbers)
        //    WriteLine(number);




        Student[] students = new[]
        {
            new Student("Leyla", "Shefiyeva", new DateOnly(2003,  1, 1)),
            new Student("Elshad", "Hesenov", new DateOnly(2005,  3, 25)),
            new Student("Murad", "Meherremli", new DateOnly(2002,  4, 19))
        };


        Array.Sort(students);


        // foreach (var student in students)
        //     WriteLine(student);



        var result = students[0].CompareTo(students[1]);


        Group group = new()
        {
            Name = "FBAS_4214_az",
            Students = students
        };



        foreach (var student in group)
            WriteLine(student);






        // IDisposable




        //using (var student = new Student())
        //{
        //    WriteLine("Test");
        //}

        //// var s = new Student();
        //// s.Dispose();

        //WriteLine("Terminated");







        using var s = new Student();
        WriteLine("Test");

        // var s = new Student();
        // s.Dispose();

        WriteLine("Terminated");



        // Same



        using var st = new Student();

        try
        {
            WriteLine("Test");
        }
        finally
        {
            st.Dispose();
        }


        // var s = new Student();
        // s.Dispose();

        WriteLine("Terminated");


    }
}