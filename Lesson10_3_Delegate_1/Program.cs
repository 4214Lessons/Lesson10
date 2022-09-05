using static System.Console;

namespace Lesson10_3_Delegate_1;


delegate void MyDel(string? text);


class Program
{

    static void Hello(string? str) => WriteLine($"Hello, {str}");
    static void GoodBye(string? str) => WriteLine($"GoodBye, {str}");


    static void DelegateLikeParam(MyDel del) => del.Invoke("C++");



    static void Main()
    {
        //// Way 1
        //MyDel myDel;
        //myDel = null;

        //// Way2
        // MyDel myDel = new MyDel(Hello);


        //// Way3
        // MyDel myDel = Hello;


        //// Way4

        MyDel myDel = null;

        // myDel += Hello;
        // myDel += WriteLine;
        // myDel += GoodBye;


        // myDel -= WriteLine;
        // myDel = WriteLine;




        // myDel("C#");
        // myDel.Invoke("C#");


        // DelegateLikeParam(myDel);






        // DelegateLikeParam(Hello);






        // Anonymous method


        myDel += delegate (string? str) { WriteLine($"Anonymous, {str}"); };
        myDel("Python");



        // DelegateLikeParam(myDel);


        // DelegateLikeParam(delegate (string? str) 
        // { 
        //     WriteLine($"Anonymous, {str}"); 
        // });



        // DelegateLikeParam(delegate (string str));




        // // Lambda
        // 
        // myDel += delegate (string? str) { WriteLine($"Anonymous, {str}"); };
        // myDel += str => WriteLine($"Lambda, {str}");
        // 
        // myDel("Python");
    }
}