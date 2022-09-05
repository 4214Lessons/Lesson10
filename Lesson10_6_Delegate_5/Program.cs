using Models;
using static System.Console;


namespace Lesson10_6_Delegate_5;


// MulticastDelegate
// Delegate


public delegate int Del(in int a, in int b);


class Program
{
    static void Main()
    {
        Del del = Methods.Add;
        del += Methods.Subt;
        del += Methods.Div;
        del += Methods.Mult;

        int? result;

        foreach (Delegate method in del.GetInvocationList())
        {
            // result = method.DynamicInvoke(6, 3) as int?;
            // WriteLine(result);


            result = method.Method.Invoke(null, new object[] { 6, 3 }) as int?;
            WriteLine(result);
        }
    }
}