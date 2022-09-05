using static System.Console;

namespace Lesson10_4_Delegate_2;


delegate void Del(string s);

class Program
{
    static void Hello(string str) => WriteLine($"Hello, {str}");
    static void GoodBye(string str) => WriteLine($"GoodBye, {str}");


    static void Main()
    {
        Del a, b, c, d;

        a = Hello;
        b = GoodBye;

        c = a + b;
        // c("C#");

        d = c - a;
        d?.Invoke("C#");
    }
}