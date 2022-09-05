using static System.Console;

namespace Models;



public class Methods
{
    public static int Add(in int a, in int b)
    {
        WriteLine("Add");
        return a + b;
    }

    public static int Div(in int a, in int b)
    {
        WriteLine("Div");
        return a / b;
    }

    public static int Mult(in int a, in int b)
    {
        WriteLine("Mult");
        return a * b;
    }
    public static int Subt(in int a, in int b)
    {
        WriteLine("Subt");
        return a - b;
    }
}
