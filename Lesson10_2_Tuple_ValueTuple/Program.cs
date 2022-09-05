namespace Lesson10_2_Tuple_ValueTuple;


class Program
{
    static (int, string) DoSomething()
    {
        return (42, "Hello");
    }


    static (int num, string str) DoSomethingWithName()
    {
        return (10, "World");
    }

    static ValueTuple<int, string> Foo()
    {
        return (10, "World");
    }


    static Tuple<int, string> Boo()
    {
        // return new Tuple<int, string>(42, "Hello");
        return new(42, "Hello");
    }

    static void Main()
    {
        Console.WriteLine(DoSomething().Item1);
        Console.WriteLine(DoSomething().Item2);

        (int, string) tuple1 = DoSomething();
        // ValueTuple<int, string> tuple1 = DoSomething();
        Console.WriteLine(tuple1.Item1);
        Console.WriteLine(tuple1.Item2);

        (int n, string s) tuple2 = DoSomethingWithName();
        Console.WriteLine(tuple2.n);
        Console.WriteLine(tuple2.s);



        // var (nn, ss) = DoSomethingWithName();
        // (int nnn, string sss) = DoSomethingWithName();

        // ValueTuple
        // Tuple<int, string> tuple3 = Boo();




        // swap

        int x = 10, y = 20;

        (x, y) = (y, x);

        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}