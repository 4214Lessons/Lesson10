using Models;

namespace Lesson10_5_Delegate_3;

delegate int ReturnTypeDel(in int a, in int b);


class Program
{
    static void Main()
    {
        ReturnTypeDel? returnTypeDel = null;

        returnTypeDel += Methods.Add;
        returnTypeDel += Methods.Div;
        returnTypeDel += Methods.Mult;
        returnTypeDel += Methods.Subt;


        Console.WriteLine(returnTypeDel?.Invoke(10, 2));
    }
}